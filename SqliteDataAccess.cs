using Dapper;
using System.Data.SQLite;
using System.Text;

namespace FinancialManager
{
    internal static class SqliteDataAccess
    {
        public const long MainCurrencyId = 1;
        public const int IncomeTransactionTypeId = 1;
        public const int ExpenseTransactionTypeId = 2;

        private static string ConnectionString => "Data Source=" + Properties.Settings.Default.PathToDb + "; Version=3; FailIfMissing=True";

        static SqliteDataAccess()
        {
            SqlMapper.AddTypeHandler(new MoneyTypeHandler());
        }

        #region Tests

        public static void TestConnection()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    connection.Close();
                }
                catch (Exception e)
                {
                    throw new Exception("Connection failed: " + e.Message, e);
                }
            }
        }

        public static void TestMainCurrencyExistance()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                var output = connection.Query<CurrencyModel>("SELECT * FROM currencies WHERE id = @Id", new { Id = MainCurrencyId }).FirstOrDefault();
                if (output == null)
                {
                    throw new Exception("Main currency not found");
                }
            }
        }

        #endregion

        #region Create DB

        public static void CreateDB()
        {
            SQLiteConnection.CreateFile(Properties.Settings.Default.PathToDb);
            CreateTables();
            FillTables();
        }

        private static void CreateTables()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
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
                            DROP TABLE IF EXISTS items;
                            DROP TABLE IF EXISTS categories;
                            DROP TABLE IF EXISTS items_tags;


                            CREATE TABLE transactions (
                            id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                            id_transaction_type INTEGER NOT NULL,
                            date DATE,
                            sum_by_cash_facility INTEGER NOT NULL,
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

                            CREATE TABLE items (
                            id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                            id_transaction INTEGER NOT NULL,
                            sum INTEGER NOT NULL,
                            sum_by_main_currency INTEGER NOT NULL,
                            id_category INTEGER NOT NULL,
                            description TEXT NOT NULL,
                            FOREIGN KEY(id_transaction) REFERENCES transactions(id),
                            FOREIGN KEY(id_category) REFERENCES categories(id));

                            CREATE TABLE categories (
                            id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                            name TEXT NOT NULL,
                            id_parent INTEGER);

                            CREATE TABLE items_tags (
                            id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
                            id_item INTEGER NOT NULL,
                            id_tag INTEGER NOT NULL,
                            FOREIGN KEY(id_item) REFERENCES items(id),
                            FOREIGN KEY(id_tag) REFERENCES tags(id));
                        ";
                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
                connection.Close();
            }
        }

        private static void FillTables()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (var command = new SQLiteCommand(connection))
                {
                    command.CommandText = $@"
                        INSERT INTO transaction_types (id, name) VALUES ({IncomeTransactionTypeId}, 'Income');
                        INSERT INTO transaction_types (id, name) VALUES ({ExpenseTransactionTypeId}, 'Expense');
                    ";
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        #endregion

        #region Load

        public static List<CurrencyModel> LoadCurrencies()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                var output = connection.Query<CurrencyModel>("SELECT * FROM currencies", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<TransactionTypeModel> LoadTransactionTypes()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                var output = connection.Query<TransactionTypeModel>("SELECT * FROM transaction_types", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<PlaceOfPurchaseModel> LoadPlacesOfPurchases()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                var output = connection.Query<PlaceOfPurchaseModel>("SELECT * FROM places_of_purchases", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<TagModel> LoadTags(long transactionTypeId = -1)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                IEnumerable<TagModel>? output;
                if (transactionTypeId == -1)
                {
                    output = connection.Query<TagModel>("SELECT * FROM tags", new DynamicParameters());
                }
                else
                {
                    output = connection.Query<TagModel>("SELECT * FROM tags WHERE id_transaction_type = @Id", new { Id = transactionTypeId });
                }
                return output.ToList();
            }
        }

        public static List<CashFacilityModel> LoadCashFacilities()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                var output = connection.Query<CashFacilityModel>("SELECT * FROM cash_facilities", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<CategoryModel> LoadCategoriesByParentId(long parentId = 0)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
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
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                var output = connection.Query<TransactionModel>("SELECT * FROM transactions", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<ItemModel> LoadItems(long transactionId)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                var output = connection.Query<ItemModel>("SELECT * FROM items WHERE id_transaction = @Id_Transaction", new { Id_Transaction = transactionId });
                return output.ToList();
            }
        }

        #endregion

        #region Add

        public static void AddCurrency(CurrencyModel currency)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Execute("INSERT INTO currencies (name, code, symbol, units_rate) VALUES (@Name, @Code, @Symbol, @Units_Rate)", currency);
            }
        }

        public static void AddTransactionType(TransactionTypeModel transactionType)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Execute("INSERT INTO transaction_types (name) VALUES (@Name)", transactionType);
            }
        }

        public static void AddPlaceOfPurchase(PlaceOfPurchaseModel placeOfPurchase)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Execute("INSERT INTO places_of_purchases (name) VALUES (@Name)", placeOfPurchase);
            }
        }

        public static void AddTag(TagModel tag)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Execute("INSERT INTO tags (name, id_transaction_type) VALUES (@Name, @Id_Transaction_Type)", tag);
            }
        }

        public static void AddCashFacility(CashFacilityModel cashFacility)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Execute("INSERT INTO cash_facilities (name, id_currency) VALUES (@Name, @Id_Currency)", cashFacility);
            }
        }

        public static void AddCategory(CategoryModel category)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
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
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                if (transaction.Id_Place_Of_Purchase == 0)
                {
                    connection.Execute("INSERT INTO transactions (id_transaction_type, date, sum_by_cash_facility, id_currency_of_transaction, id_cash_facility, description) VALUES (@Id_Transaction_Type, @Date, @Sum_By_Cash_Facility, @Id_Currency_Of_Transaction, @Id_Cash_Facility, @Description)", transaction);
                }
                else
                {
                    connection.Execute("INSERT INTO transactions (id_transaction_type, date, sum_by_cash_facility, id_currency_of_transaction, id_cash_facility, id_place_of_purchase, description) VALUES (@Id_Transaction_Type, @Date, @Sum_By_Cash_Facility, @Id_Currency_Of_Transaction, @Id_Cash_Facility, @Id_Place_Of_Purchase, @Description)", transaction);
                }
            }
        }

        public static void AddItem(ItemModel item, List<long>? tagsId)
        {
            tagsId ??= new List<long>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    connection.Execute("INSERT INTO items (id_transaction, sum, sum_by_main_currency, id_category, description) VALUES (@Id_Transaction, @Sum, @Sum_By_Main_Currency, @Id_Category, @Description)", item);

                    var lastAddedItemId = GetLastAddedItemId() + 1;

                    foreach (var tagId in tagsId)
                    {
                        connection.Execute("INSERT INTO items_tags (id_item, id_tag) VALUES (@Id_Item, @Id_Tag)", new { Id_Item = lastAddedItemId, Id_Tag = tagId });
                    }

                    transaction.Commit();
                }
                connection.Close();
            }
        }

        #endregion

        #region Update

        public static void UpdateCurrency(CurrencyModel currency)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Execute("UPDATE currencies SET name = @Name, code = @Code, symbol = @Symbol, units_rate = @Units_Rate WHERE id = @Id", currency);
            }
        }

        public static void UpdateTransactionType(TransactionTypeModel transactionType)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Execute("UPDATE transaction_types SET name = @Name WHERE id = @Id", transactionType);
            }
        }

        public static void UpdatePlaceOfPurchase(PlaceOfPurchaseModel placeOfPurchase)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Execute("UPDATE places_of_purchases SET name = @Name WHERE id = @Id", placeOfPurchase);
            }
        }

        public static void UpdateTag(TagModel tag)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Execute("UPDATE tags SET name = @Name, id_transaction_type = @Id_Transaction_Type WHERE id = @Id", tag);
            }
        }

        public static void UpdateCashFacility(CashFacilityModel cashFacility)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Execute("UPDATE cash_facilities SET name = @Name, id_currency = @Id_Currency WHERE id = @Id", cashFacility);
            }
        }

        public static void UpdateCategory(CategoryModel category)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
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
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                if (transaction.Id_Place_Of_Purchase == 0)
                {
                    connection.Execute("UPDATE transactions SET id_transaction_type = @Id_Transaction_Type, date = @Date, sum_by_cash_facility = @Sum_By_Cash_Facility, id_currency_of_transaction = @Id_Currency_Of_Transaction, id_cash_facility = @Id_Cash_Facility, id_place_of_purchase = NULL, description = @Description WHERE id = @Id", transaction);
                }
                else
                {
                    connection.Execute("UPDATE transactions SET id_transaction_type = @Id_Transaction_Type, date = @Date, sum_by_cash_facility = @Sum_By_Cash_Facility, id_currency_of_transaction = @Id_Currency_Of_Transaction, id_cash_facility = @Id_Cash_Facility, id_place_of_purchase = @Id_Place_Of_Purchase, description = @Description WHERE id = @Id", transaction);
                }
            }
        }

        public static void UpdateItem(ItemModel item, List<long>? tagsId)
        {
            tagsId ??= new List<long>();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    connection.Execute("UPDATE items SET id_transaction = @Id_Transaction, sum = @Sum, sum_by_main_currency = @Sum_By_Main_Currency, id_category = @Id_Category, description = @Description WHERE id = @Id", item);

                    connection.Execute("DELETE FROM items_tags WHERE id_item = @Id", new { Id = item.Id });

                    foreach (var tagId in tagsId)
                    {
                        connection.Execute("INSERT INTO items_tags (id_item, id_tag) VALUES (@Id_Item, @Id_Tag)", new { Id_Item = item.Id, Id_Tag = tagId });
                    }

                    transaction.Commit();
                }
                connection.Close();
            }
        }

        #endregion

        #region Get By Id

        public static CurrencyModel GetCurrencyById(long id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                var output = connection.Query<CurrencyModel>("SELECT * FROM currencies WHERE id = @Id", new { Id = id }).FirstOrDefault();
                return output;
            }
        }

        public static TransactionTypeModel GetTransactionTypeById(long id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                var output = connection.Query<TransactionTypeModel>("SELECT * FROM transaction_types WHERE id = @Id", new { Id = id }).FirstOrDefault();
                return output;
            }
        }

        public static PlaceOfPurchaseModel GetPlaceOfPurchaseById(long id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                var output = connection.Query<PlaceOfPurchaseModel>("SELECT * FROM places_of_purchases WHERE id = @Id", new { Id = id }).FirstOrDefault();
                return output;
            }
        }

        public static TagModel GetTagById(long id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                var output = connection.Query<TagModel>("SELECT * FROM tags WHERE id = @Id", new { Id = id }).FirstOrDefault();
                return output;
            }
        }

        public static List<TagModel> GetTagsByItemId(long itemId)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                var output = connection.Query<TagModel>("SELECT tags.* FROM tags JOIN items_tags ON tags.id = items_tags.id_tag WHERE items_tags.id_item = @Id", new { Id = itemId });
                return output.ToList();
            }
        }

        public static CashFacilityModel GetCashFacilityById(long id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                var output = connection.Query<CashFacilityModel>("SELECT * FROM cash_facilities WHERE id = @Id", new { Id = id }).FirstOrDefault();
                return output;
            }
        }

        public static CategoryModel GetCategoryById(long id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                var output = connection.Query<CategoryModel>("SELECT * FROM categories WHERE id = @Id", new { Id = id }).FirstOrDefault();
                return output;
            }
        }

        public static TransactionModel GetTransactionById(long id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                var output = connection.Query<TransactionModel>("SELECT * FROM transactions WHERE id = @Id", new { Id = id }).FirstOrDefault();
                return output;
            }
        }

        public static ItemModel GetItemById(long id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                var output = connection.Query<ItemModel>("SELECT * FROM items WHERE id = @Id", new { Id = id }).FirstOrDefault();
                return output;
            }
        }

        #endregion

        #region Delete

        public static void DeleteCurrencyById(long id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Execute("DELETE FROM currencies WHERE id = @Id", new { Id = id });
            }
        }

        public static void DeleteTransactionTypeById(long id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Execute("DELETE FROM transaction_types WHERE id = @Id", new { Id = id });
            }
        }

        public static void DeletePlaceOfPurchaseById(long id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Execute("DELETE FROM places_of_purchases WHERE id = @Id", new { Id = id });
            }
        }

        public static void DeleteTagById(long id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Execute("DELETE FROM tags WHERE id = @Id", new { Id = id });
            }
        }

        public static void DeleteCashFacilityById(long id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Execute("DELETE FROM cash_facilities WHERE id = @Id", new { Id = id });
            }
        }

        public static void DeleteCategoryById(long id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Execute("DELETE FROM categories WHERE id = @Id", new { Id = id });
            }
        }

        public static void DeleteTransactionById(long id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Execute("DELETE FROM transactions WHERE id = @Id", new { Id = id });
            }
        }

        public static void DeleteItemById(long id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    connection.Execute("DELETE FROM items_tags WHERE id_item = @Id", new { Id = id });
                    connection.Execute("DELETE FROM items WHERE id = @Id", new { Id = id });

                    transaction.Commit();
                }
                connection.Close();
            }
        }

        #endregion

        #region Get (Other)

        public static int GetUnitsRate(long idCashFacility)
        {
            var cashFacility = GetCashFacilityById(idCashFacility);
            return GetUnitsRate(cashFacility);
        }

        public static int GetUnitsRate(CashFacilityModel cashFacility)
        {
            var cashFacilityCurrency = GetCurrencyById(cashFacility.Id_Currency);
            return cashFacilityCurrency.Units_Rate;
        }

        public static long GetLastAddedTransactionId()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                var output = connection.ExecuteScalar<long>("SELECT seq FROM sqlite_sequence WHERE name = 'transactions'");
                return output;
            }
        }

        public static long GetLastAddedItemId()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                var output = connection.ExecuteScalar<long>("SELECT seq FROM sqlite_sequence WHERE name = 'items'");
                return output;
            }
        }

        public static CurrencyModel GetMainCurrency()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                var output = connection.Query<CurrencyModel>("SELECT * FROM currencies WHERE id = @Id", new { Id = MainCurrencyId }).First();
                return output;
            }
        }

        public static List<ItemAnalysisModel> GetItems(long categoryId, long transactionTypeId, DateTime? fromDate, DateTime? toDate, long placeOfPurchaseId)
        {
            var queryStart = @"SELECT 
                                items.id as Id, categories.name AS Category, 
                                transactions.date AS Date, sum as Sum, 
                                currencies.id AS CurrencyId, 
                                sum_by_main_currency AS SumByMainCurrency, 
                                places_of_purchases.name AS Place, 
                                id_transaction_type AS TransactionTypeId 
                               FROM items 
                               LEFT JOIN transactions ON items.id_transaction = transactions.id 
                               LEFT JOIN currencies ON id_currency_of_transaction = currencies.id 
                               LEFT JOIN places_of_purchases ON id_place_of_purchase = places_of_purchases.id 
                               LEFT JOIN categories ON id_category = categories.id";
            var queryBuilder = new StringBuilder(queryStart);
            var parametersBuilder = new StringBuilder();
            var categoriesIds = new List<long>();

            if (transactionTypeId != -1)
            {
                if (parametersBuilder.Length > 0) parametersBuilder.Append("AND ");
                parametersBuilder.Append("id_transaction_type = @TransactionTypeId ");
            }
            if (fromDate != null)
            {
                if (parametersBuilder.Length > 0) parametersBuilder.Append("AND ");
                parametersBuilder.Append("date >= @FromDate ");
            }
            if (toDate != null)
            {
                if (parametersBuilder.Length > 0) parametersBuilder.Append("AND ");
                parametersBuilder.Append("date <= @ToDate ");
            }
            if (placeOfPurchaseId != -1)
            {
                if (parametersBuilder.Length > 0) parametersBuilder.Append("AND ");
                parametersBuilder.Append("id_place_of_purchase = @PlaceOfPurchaseId ");
            }

            if (categoryId != -1)
            {
                var categories = new Queue<CategoryModel>();
                categories.Enqueue(GetCategoryById(categoryId));
                categoriesIds.Add(categoryId);

                while (categories.Count > 0)
                {
                    var category = categories.Dequeue();
                    var subCategories = LoadCategoriesByParentId(category.Id);
                    foreach (var subCategory in subCategories)
                    {
                        categoriesIds.Add(subCategory.Id);
                        categories.Enqueue(subCategory);
                    }
                }

                var categoriesIdsString = String.Join(", ", categoriesIds.ToArray());

                if (parametersBuilder.Length > 0) parametersBuilder.Append("AND ");
                parametersBuilder.Append($"id_category IN ( {categoriesIdsString} )");
            }

            if (parametersBuilder.Length > 0)
            {
                queryBuilder.Append(" WHERE ");
                queryBuilder.Append(parametersBuilder);
            }

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                var itemsAnalysis = connection.Query<ItemAnalysisModel>(queryBuilder.ToString(), new { TransactionTypeId = transactionTypeId, FromDate = fromDate, ToDate = toDate, PlaceOfPurchaseId = placeOfPurchaseId }).ToList();

                var mainCurrency = GetMainCurrency();
                foreach (var item in itemsAnalysis)
                {
                    var currency = GetCurrencyById(item.CurrencyId);

                    item.Sum.Rate = currency.Units_Rate;
                    item.CurrencyText = currency.MoneyText;

                    item.SumByMainCurrency.Rate = mainCurrency.Units_Rate;

                    var tags = GetTagsByItemId(item.Id);

                    StringBuilder tagsStringBuilder = new StringBuilder();
                    foreach (var tag in tags)
                    {
                        if (tagsStringBuilder.Length > 0)
                            tagsStringBuilder.Append(", ");

                        tagsStringBuilder.Append(tag.Name);
                    }

                    item.Tags = tagsStringBuilder.ToString();
                }

                return itemsAnalysis;
            }
        }

        public static long GetItemsCount(long transactionTypeId)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                if (transactionTypeId == -1)
                {
                    var output = connection.ExecuteScalar<long>("SELECT COUNT(*) FROM items");
                    return output;
                }
                else
                {
                    var output = connection.ExecuteScalar<long>("SELECT COUNT(*) FROM items JOIN transactions ON id_transaction = transactions.id WHERE id_transaction_type = @IdTransactionType", new { IdTransactionType = transactionTypeId });
                    return output;
                }
            }
        }

        #endregion
    }
}
