using Academia2.Data;
using System;
using System.Data;
using System.Data.SQLite;  // <-- cambia el using

namespace Academia2.Repositories
{
    public class DanzasRepository
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
                        SELECT id, nombre, status
                        FROM danza
                        ORDER BY nombre;";
                    using (var rdr = cmd.ExecuteReader())
                        dt.Load(rdr);
                }
            }
            return dt;
        }
    }
}
