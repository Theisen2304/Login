using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace SecDashboard
{
    public static class DatenBankManager
    {
        private static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\login_history.sqlite");
        private static string connectionString = $"Data Source={dbPath};Version=3;";
        public static string ConnectionString => connectionString;


        public static void InitializeDatabase()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createTableQuery = @"
                CREATE TABLE IF NOT EXISTS LoginHistory (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL,
                    Timestamp TEXT NOT NULL,
                    Status TEXT NOT NULL
                );";

                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddLoginEntry(string username, string status)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO LoginHistory (Username, Timestamp, Status) VALUES (@username, @timestamp, @status)";

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@timestamp", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@status", status);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
