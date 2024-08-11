using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager
{
    internal static class SqliteDataAccess
    {
        public static string? PathToDB { get; set; }
        public static bool IsPathToDBCorrect { get; set; }

        public static string TestConnection()
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    connection.Open();
                    connection.Close();

                    IsPathToDBCorrect = true;
                    return "DB connection OK!";
                }
                catch (Exception)
                {
                    IsPathToDBCorrect = false;
                    return "DB connection FAILED!";
                }
            }
        }

        private static string LoadConnectionString()
        {
            return "Data Source=" + PathToDB + "; Version=3; FailIfMissing=True";
        }
    }
}
