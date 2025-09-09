using System;
using System.IO;
using System.Data.SQLite; // <-- cambia el using

namespace Academia2.Data
{
    public static class SqliteConnectionFactory
    {
        public static string GetDbPath()
        {
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            return Path.Combine(baseDir, "data", "academia.db");
        }

        public static SQLiteConnection Create()
        {
            var dbPath = GetDbPath();
            if (!File.Exists(dbPath))
                throw new FileNotFoundException($"No se encontró la base en: {dbPath}");

            var cs = $"Data Source={dbPath};Version=3;Foreign Keys=True;";
            return new SQLiteConnection(cs);
        }
    }
}
