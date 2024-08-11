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
        public static string? DBName { get; set; }

        public static bool TestConnection()
        {
            /*using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();
                connection.Close();
            }*/

            var connection = new SQLiteConnection(LoadConnectionString());
            try
            {
                connection.Open();
                connection.Close();

                return true;
            }
            catch (Exception ex)
            {
                // Console.WriteLine(ex.Message);

                return false;
            }
        }

        private static string LoadConnectionString()
        {
            return "Data Source=" + DBName + "; Version=3; FailIfMissing=True";
        }
    }
}
