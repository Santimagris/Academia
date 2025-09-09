using Academia2.Data;
using System;
using System.Data;
using System.Data.SQLite;  // <-- cambia el using

namespace Academia2.Repositories
{
    public class AlumnasRepository
    {
        public DataTable GetAllAsDataTable()
        {
            var dt = new DataTable();
            using (var con = SqliteConnectionFactory.Create())
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT id, apellido, nombre, dni, direccion, status
                        FROM alumna
                        ORDER BY apellido, nombre;";
                    using (var rdr = cmd.ExecuteReader())
                        dt.Load(rdr);
                }
            }
            return dt;
        }
        public static int DebugCount()
        {
            using (var con = Academia2.Data.SqliteConnectionFactory.Create())
            {
                con.Open();
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM alumna;";
                    object o = cmd.ExecuteScalar();
                    return Convert.ToInt32(o);
                }
            }
        }

    }
}
