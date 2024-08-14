using Dapper;
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

        public static void CreateDB()
        {
            SQLiteConnection.CreateFile(PathToDB);
            CreateTables();
        }

        private static void CreateTables()
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    using (var command = new SQLiteCommand(connection))
                    {
                        command.CommandText = @"
                            DROP TABLE IF EXISTS transactions;
                            DROP TABLE IF EXISTS currencies;
                            DROP TABLE IF EXISTS cash_facilities;
                            DROP TABLE IF EXISTS places_of_purchases;
                            DROP TABLE IF EXISTS tags;
                            DROP TABLE IF EXISTS transaction_types;
                            DROP TABLE IF EXISTS users;
                            DROP TABLE IF EXISTS purchases;
                            DROP TABLE IF EXISTS categories_1;
                            DROP TABLE IF EXISTS categories_2;
                            DROP TABLE IF EXISTS categories_3;
                            DROP TABLE IF EXISTS purposes;
                            DROP TABLE IF EXISTS purchases_tags;


                            CREATE TABLE transactions (
                            id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                            id_transaction_type INTEGER NOT NULL,
                            date DATE,
                            sum_by_account INTEGER NOT NULL,
                            id_currency_of_transaction INTEGER NOT NULL,
                            id_cash_facility INTEGER NOT NULL,
                            id_place_of_purchase INTEGER NOT NULL,
                            description TEXT NOT NULL,
                            FOREIGN KEY(id_transaction_type) REFERENCES transaction_types(id),
                            FOREIGN KEY(id_currency_of_transaction) REFERENCES currencies(id),
                            FOREIGN KEY(id_cash_facility) REFERENCES cash_facilities(id),
                            FOREIGN KEY(id_place_of_purchase) REFERENCES places_of_purchases(id));

                            CREATE TABLE currencies (
                            id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                            name TEXT NOT NULL UNIQUE,
                            code TEXT NOT NULL UNIQUE,
                            symbol TEXT NOT NULL);

                            CREATE TABLE cash_facilities (
                            id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                            name TEXT NOT NULL UNIQUE,
                            id_currency INTEGER NOT NULL,
                            FOREIGN KEY(id_currency) REFERENCES currencies(id));

                            CREATE TABLE places_of_purchases (
                            id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                            name TEXT NOT NULL UNIQUE);

                            CREATE TABLE tags (
                            id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                            name TEXT NOT NULL UNIQUE,
                            id_transaction_type INTEGER,
                            FOREIGN KEY(id_transaction_type) REFERENCES transaction_types(id));

                            CREATE TABLE transaction_types (
                            id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                            name TEXT NOT NULL UNIQUE);

                            CREATE TABLE users (
                            id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                            username TEXT NOT NULL UNIQUE,
                            password_hash TEXT NOT NULL);

                            CREATE TABLE purchases (
                            id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                            id_transaction INTEGER NOT NULL,
                            sum_by_transaction INTEGER NOT NULL,
                            id_category_1 INTEGER NOT NULL,
                            id_category_2 INTEGER NOT NULL,
                            id_category_3 INTEGER NOT NULL,
                            id_purpose INTEGER,
                            description TEXT NOT NULL,
                            FOREIGN KEY(id_transaction) REFERENCES transactions(id),
                            FOREIGN KEY(id_category_1) REFERENCES categories_1(id),
                            FOREIGN KEY(id_category_2) REFERENCES categories_2(id),
                            FOREIGN KEY(id_category_3) REFERENCES categories_3(id),
                            FOREIGN KEY(id_purpose) REFERENCES purposes(id));

                            CREATE TABLE categories_1 (
                            id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                            name TEXT NOT NULL UNIQUE,
                            id_parent INTEGER);

                            CREATE TABLE categories_2 (
                            id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                            name TEXT NOT NULL,
                            id_parent INTEGER NOT NULL,
                            FOREIGN KEY(id_parent) REFERENCES categories_1(id));

                            CREATE TABLE categories_3 (
                            id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                            name TEXT NOT NULL,
                            id_parent INTEGER NOT NULL,
                            FOREIGN KEY(id_parent) REFERENCES categories_2(id));

                            CREATE TABLE purposes (
                            id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                            name TEXT NOT NULL UNIQUE,
                            id_transaction_type INTEGER NOT NULL,
                            FOREIGN KEY(id_transaction_type) REFERENCES transaction_types(id));

                            CREATE TABLE purchases_tags (
                            id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                            id_purchase INTEGER NOT NULL,
                            id_tag INTEGER NOT NULL,
                            FOREIGN KEY(id_purchase) REFERENCES purchases(id),
                            FOREIGN KEY(id_tag) REFERENCES tags(id));
                        ";
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
                connection.Close();
            }
        }

        public static List<CurrencyModel> LoadCurrencies()
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<CurrencyModel>("SELECT * FROM currencies", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<TransactionTypeModel> LoadTransactionTypes()
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<TransactionTypeModel>("SELECT * FROM transaction_types", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void AddCurrency(CurrencyModel currency)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("INSERT INTO currencies (name, code, symbol) VALUES (@Name, @Code, @Symbol)", currency);
            }
        }

        public static void AddTransactionType(TransactionTypeModel transactionType)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("INSERT INTO transaction_types (name) VALUES (@Name)", transactionType);
            }
        }

        public static void UpdateCurrency(CurrencyModel currency)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("UPDATE currencies SET name = @Name, code = @Code, symbol = @Symbol WHERE id = @Id", currency);
            }
        }

        public static void UpdateTransactionType(TransactionTypeModel transactionType)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("UPDATE transaction_types SET name = @Name WHERE id = @Id", transactionType);
            }
        }

        public static CurrencyModel GetCurrencyById(long id)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<CurrencyModel>("SELECT * FROM currencies WHERE id = @Id", new { Id = id }).FirstOrDefault();
                return output;
            }
        }

        public static TransactionTypeModel GetTransactionTypeById(long id)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<TransactionTypeModel>("SELECT * FROM transaction_types WHERE id = @Id", new { Id = id }).FirstOrDefault();
                return output;
            }
        }

        public static void DeleteCurrencyById(long id)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("DELETE FROM currencies WHERE id = @Id", new { Id = id });
            }
        }

        public static void DeleteTransactionTypeById(long id)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("DELETE FROM transaction_types WHERE id = @Id", new { Id = id });
            }
        }

        private static string LoadConnectionString()
        {
            return "Data Source=" + PathToDB + "; Version=3; FailIfMissing=True";
        }
    }
}
