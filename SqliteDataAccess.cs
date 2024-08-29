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

        static SqliteDataAccess()
        {
            SqlMapper.AddTypeHandler(new MoneyTypeHandler());
        }

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
                            DROP TABLE IF EXISTS purchases;
                            DROP TABLE IF EXISTS categories;
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
                            symbol TEXT NOT NULL,
                            units_rate INTEGER NOT NULL);

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

                            CREATE TABLE purchases (
                            id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                            id_transaction INTEGER NOT NULL,
                            sum_by_transaction INTEGER NOT NULL,
                            id_category INTEGER NOT NULL,
                            description TEXT NOT NULL,
                            FOREIGN KEY(id_transaction) REFERENCES transactions(id),
                            FOREIGN KEY(id_category) REFERENCES categories(id));

                            CREATE TABLE categories (
                            id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                            name TEXT NOT NULL,
                            id_parent INTEGER);

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

        public static List<PlaceOfPurchaseModel> LoadPlacesOfPurchases()
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<PlaceOfPurchaseModel>("SELECT * FROM places_of_purchases", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<TagModel> LoadTags()
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<TagModel>("SELECT * FROM tags", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<CashFacilityModel> LoadCashFacilities()
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<CashFacilityModel>("SELECT * FROM cash_facilities", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<CategoryModel> LoadCategoriesByParentId(long parentId = 0)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                IEnumerable<CategoryModel>? output;
                if (parentId == 0)
                {
                    output = connection.Query<CategoryModel>("SELECT * FROM categories WHERE id_parent IS NULL", new DynamicParameters());
                }
                else
                {
                    output = connection.Query<CategoryModel>("SELECT * FROM categories WHERE id_parent = @Id_Parent", new { Id_Parent = parentId });
                }
                return output.ToList();
            }
        }

        public static List<TransactionModel> LoadTransactions()
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<TransactionModel>("SELECT * FROM transactions", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<PurchaseModel> LoadPurchases(long transactionId)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<PurchaseModel>($"SELECT * FROM purchases WHERE id_transaction = {transactionId}", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void AddCurrency(CurrencyModel currency)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("INSERT INTO currencies (name, code, symbol, units_rate) VALUES (@Name, @Code, @Symbol, @Units_Rate)", currency);
            }
        }

        public static void AddTransactionType(TransactionTypeModel transactionType)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("INSERT INTO transaction_types (name) VALUES (@Name)", transactionType);
            }
        }

        public static void AddPlaceOfPurchase(PlaceOfPurchaseModel placeOfPurchase)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("INSERT INTO places_of_purchases (name) VALUES (@Name)", placeOfPurchase);
            }
        }

        public static void AddTag(TagModel tag)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("INSERT INTO tags (name, id_transaction_type) VALUES (@Name, @Id_Transaction_Type)", tag);
            }
        }

        public static void AddCashFacility(CashFacilityModel cashFacility)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("INSERT INTO cash_facilities (name, id_currency) VALUES (@Name, @Id_Currency)", cashFacility);
            }
        }

        public static void AddCategory(CategoryModel category)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                if (category.Id_Parent == 0)
                {
                    connection.Execute("INSERT INTO categories (name) VALUES (@Name)", category);
                }
                else
                {
                    connection.Execute("INSERT INTO categories (name, id_parent) VALUES (@Name, @Id_Parent)", category);
                }
            }
        }

        public static void AddTransaction(TransactionModel transaction)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                if (transaction.Id_Place_Of_Purchase == 0)
                {
                    connection.Execute("INSERT INTO transactions (id_transaction_type, date, sum_by_account, id_currency_of_transaction, id_cash_facility, description) VALUES (@Id_Transaction_Type, @Date, @Sum_By_Account, @Id_Currency_Of_Transaction, @Id_Cash_Facility, @Description)", transaction);
                }
                else
                {
                    connection.Execute("INSERT INTO transactions (id_transaction_type, date, sum_by_account, id_currency_of_transaction, id_cash_facility, id_place_of_purchase, description) VALUES (@Id_Transaction_Type, @Date, @Sum_By_Account, @Id_Currency_Of_Transaction, @Id_Cash_Facility, @Id_Place_Of_Purchase, @Description)", transaction);
                }
            }
        }

        public static void AddPurchase(PurchaseModel purchase, List<long> tagsId = null)
        {
            tagsId ??= new List<long>();

            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    connection.Execute("INSERT INTO purchases (id_transaction, sum_by_transaction, id_category, description) VALUES (@Id_Transaction, @Sum_By_Transaction, @Id_Category, @Description)", purchase);

                    var lastAddedPurchaseId = GetLastAddedPurchaseId() + 1;

                    foreach (var tagId in tagsId)
                    {
                        connection.Execute("INSERT INTO purchases_tags (id_purchase, id_tag) VALUES (@Id_Purchase, @Id_Tag)", new { Id_Purchase = lastAddedPurchaseId, Id_Tag = tagId });
                    }

                    transaction.Commit();
                }
                connection.Close();
            }
        }

        public static void UpdateCurrency(CurrencyModel currency)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("UPDATE currencies SET name = @Name, code = @Code, symbol = @Symbol, units_rate = @Units_Rate WHERE id = @Id", currency);
            }
        }

        public static void UpdateTransactionType(TransactionTypeModel transactionType)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("UPDATE transaction_types SET name = @Name WHERE id = @Id", transactionType);
            }
        }

        public static void UpdatePlaceOfPurchase(PlaceOfPurchaseModel placeOfPurchase)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("UPDATE places_of_purchases SET name = @Name WHERE id = @Id", placeOfPurchase);
            }
        }

        public static void UpdateTag(TagModel tag)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("UPDATE tags SET name = @Name, id_transaction_type = @Id_Transaction_Type WHERE id = @Id", tag);
            }
        }

        public static void UpdateCashFacility(CashFacilityModel cashFacility)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("UPDATE cash_facilities SET name = @Name, id_currency = @Id_Currency WHERE id = @Id", cashFacility);
            }
        }

        public static void UpdateCategory(CategoryModel category)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                if (category.Id_Parent == 0)
                {
                    connection.Execute("UPDATE categories SET name = @Name, id_parent = NULL WHERE id = @Id", category);
                }
                else
                {
                    connection.Execute("UPDATE categories SET name = @Name, id_parent = @Id_Parent WHERE id = @Id", category);
                }
            }
        }

        public static void UpdateTransaction(TransactionModel transaction)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                if (transaction.Id_Place_Of_Purchase == 0)
                {
                    connection.Execute("UPDATE transactions SET id_transaction_type = @Id_Transaction_Type, date = @Date, sum_by_account = @Sum_By_Account, id_currency_of_transaction = @Id_Currency_Of_Transaction, id_cash_facility = @Id_Cash_Facility, id_place_of_purchase = NULL, description = @Description WHERE id = @Id", transaction);
                }
                else
                {
                    connection.Execute("UPDATE transactions SET id_transaction_type = @Id_Transaction_Type, date = @Date, sum_by_account = @Sum_By_Account, id_currency_of_transaction = @Id_Currency_Of_Transaction, id_cash_facility = @Id_Cash_Facility, id_place_of_purchase = @Id_Place_Of_Purchase, description = @Description WHERE id = @Id", transaction);
                }
            }
        }

        public static void UpdatePurchase(PurchaseModel purchase)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("UPDATE purchases SET id_transaction = @Id_Transaction, sum_by_transaction = @Sum_By_Transaction, id_category = @Id_Category, description = @Description WHERE id = @Id", purchase);
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

        public static PlaceOfPurchaseModel GetPlaceOfPurchaseById(long id)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<PlaceOfPurchaseModel>("SELECT * FROM places_of_purchases WHERE id = @Id", new { Id = id }).FirstOrDefault();
                return output;
            }
        }

        public static TagModel GetTagById(long id)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<TagModel>("SELECT * FROM tags WHERE id = @Id", new { Id = id }).FirstOrDefault();
                return output;
            }
        }

        public static CashFacilityModel GetCashFacilityById(long id)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<CashFacilityModel>("SELECT * FROM cash_facilities WHERE id = @Id", new { Id = id }).FirstOrDefault();
                return output;
            }
        }

        public static CategoryModel GetCategoryById(long id)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<CategoryModel>("SELECT * FROM categories WHERE id = @Id", new { Id = id }).FirstOrDefault();
                return output;
            }
        }

        public static TransactionModel GetTransactionById(long id)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<TransactionModel>("SELECT * FROM transactions WHERE id = @Id", new { Id = id }).FirstOrDefault();
                return output;
            }
        }

        public static PurchaseModel GetPurchaseById(long id)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.Query<PurchaseModel>("SELECT * FROM purchases WHERE id = @Id", new { Id = id }).FirstOrDefault();
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

        public static void DeletePlaceOfPurchaseById(long id)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("DELETE FROM places_of_purchases WHERE id = @Id", new { Id = id });
            }
        }

        public static void DeleteTagById(long id)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("DELETE FROM tags WHERE id = @Id", new { Id = id });
            }
        }

        public static void DeleteCashFacilityById(long id)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("DELETE FROM cash_facilities WHERE id = @Id", new { Id = id });
            }
        }

        public static void DeleteCategoryById(long id)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("DELETE FROM categories WHERE id = @Id", new { Id = id });
            }
        }

        public static void DeleteTransactionById(long id)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Execute("DELETE FROM transactions WHERE id = @Id", new { Id = id });
            }
        }

        public static void DeletePurchaseById(long id)
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    connection.Execute("DELETE FROM purchases_tags WHERE id_purchase = @Id", new { Id = id });
                    connection.Execute("DELETE FROM purchases WHERE id = @Id", new { Id = id });

                    transaction.Commit();
                }
                connection.Close();
            }
        }

        public static int GetUnitsRate(long idCashFacility)
        {
            var cashFacility = SqliteDataAccess.GetCashFacilityById(idCashFacility);
            return GetUnitsRate(cashFacility);
        }

        public static int GetUnitsRate(CashFacilityModel cashFacility)
        {
            var cashFacilityCurrency = SqliteDataAccess.GetCurrencyById(cashFacility.Id_Currency);
            return cashFacilityCurrency.Units_Rate;
        }

        public static long GetLastAddedTransactionId()
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.ExecuteScalar<long>("SELECT seq FROM sqlite_sequence WHERE name = 'transactions'");
                return output;
            }
        }

        public static long GetLastAddedPurchaseId()
        {
            using (var connection = new SQLiteConnection(LoadConnectionString()))
            {
                var output = connection.ExecuteScalar<long>("SELECT seq FROM sqlite_sequence WHERE name = 'purchases'");
                return output;
            }
        }

        private static string LoadConnectionString()
        {
            return "Data Source=" + PathToDB + "; Version=3; FailIfMissing=True";
        }
    }
}
