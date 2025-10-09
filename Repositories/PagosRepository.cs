using Academia2.Data;
using System;
using System.Data;
using System.Data.SQLite;  // <-- cambia el using

namespace Academia2.Repositories
{
    public class PagosRepository
    {
        public DataTable GetPagadosAsDataTable(string mes)
        {
            var dt = new DataTable();
            using (var con = SqliteConnectionFactory.Create())
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT a.apellido, a.nombre, p.monto_abonado
                        FROM pago p
                        JOIN alumna a ON a.id = p.id_alumna
                        WHERE p.mes = @mes
                          AND a.status = 'activa'
                          AND p.monto_abonado >= p.monto
                        ORDER BY a.apellido, a.nombre;";
                    cmd.Parameters.AddWithValue("@mes", mes);

                    using (var rdr = cmd.ExecuteReader())
                        dt.Load(rdr);
                }
            }
            return dt;
        }

        public DataTable GetPagadosParcialAsDataTable(string mes)
        {
            var dt = new DataTable();
            using (var con = SqliteConnectionFactory.Create())
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT a.apellido, a.nombre,
                               p.monto_abonado,
                               (p.monto - p.monto_abonado) AS saldo
                        FROM pago p
                        JOIN alumna a ON a.id = p.id_alumna
                        WHERE p.mes = @mes
                          AND a.status = 'activa'
                          AND p.monto_abonado > 0
                          AND p.monto_abonado < p.monto
                        ORDER BY a.apellido, a.nombre;";
                    cmd.Parameters.AddWithValue("@mes", mes);

                    using (var rdr = cmd.ExecuteReader())
                        dt.Load(rdr);
                }
            }
            return dt;
        }

        public DataTable GetNoPagadosAsDataTable(string mes)
        {
            var dt = new DataTable();
            using (var con = SqliteConnectionFactory.Create())
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT a.apellido, a.nombre
                        FROM alumna a
                        LEFT JOIN pago p
                          ON p.id_alumna = a.id AND p.mes = @mes
                        WHERE a.status = 'activa'
                          AND (p.id IS NULL OR p.monto_abonado = 0)
                        ORDER BY a.apellido, a.nombre;";
                    cmd.Parameters.AddWithValue("@mes", mes);

                    using (var rdr = cmd.ExecuteReader())
                        dt.Load(rdr);
                }
            }
            return dt;
        }
    }
}
