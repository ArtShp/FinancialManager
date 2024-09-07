using System.Globalization;

namespace FinancialManager
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            // Set the culture to en-GB for correct decimal separator (period instead of comma)
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
        }

        #region Tests

        private void TestDbConnection()
        {
            try
            {
                SqliteDataAccess.TestConnection();
            }
            catch
            {
                MessageBox.Show("Connection to DB failed!\nPlease choose DB file or create a new one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TestMainCurrencyExistance()
        {
            try
            {
                SqliteDataAccess.TestMainCurrencyExistance();
            }
            catch
            {
                MessageBox.Show("Main currency does not exist!\nPlease create it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Main Window Event Handlers

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            TestDbConnection();
        }

        #endregion

        #region Menu Event Handlers

        #region File Menu

        private void createDbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (createDBDialog.ShowDialog() == DialogResult.Cancel)
                return;

            Properties.Settings.Default.PathToDb = createDBDialog.FileName;

            try
            {
                SqliteDataAccess.CreateDB();
                SqliteDataAccess.TestConnection();

                Properties.Settings.Default.Save();

                MessageBox.Show("DB created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TestMainCurrencyExistance();
            }
            catch
            {
                Properties.Settings.Default.Reload();

                MessageBox.Show("Creation of DB failed!\nPlease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openDbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openDBDialog.ShowDialog() == DialogResult.Cancel)
                return;

            Properties.Settings.Default.PathToDb = openDBDialog.FileName;

            try
            {
                SqliteDataAccess.TestConnection();

                Properties.Settings.Default.Save();

                MessageBox.Show("Connection to DB successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TestMainCurrencyExistance();
            }
            catch
            {
                Properties.Settings.Default.Reload();

                MessageBox.Show("Connection to DB failed!\nPlease choose another DB file or create a new one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeDbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to close the DB?", "Close DB", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
                return;

            Properties.Settings.Default.PathToDb = "";
            Properties.Settings.Default.Save();

            MessageBox.Show("DB closed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Edit Menu

        private void editCurrenciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCurrencies();
        }

        private void editTransactionTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTransactionTypes();
        }

        private void editPlacesOfPurchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPlacesOfPurchases();
        }

        private void editTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTags();
        }

        private void editCashFacilitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCashFacilities();
        }

        private void editCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCategories();
        }

        private void editTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTransactions();
        }

        #endregion

        #region Analyze Menu

        private void analyzeItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnalyzeItems();
        }

        #endregion

        #region Settings Menu

        private void setCurrencyAPIKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCurrencyApiKey();
        }

        #endregion

        #region Tests Menu

        private void currencyExchangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyExchange();
        }

        #endregion

        #endregion

        #region Buttons Click Handlers

        private void editCurrenciesButton_Click(object sender, EventArgs e)
        {
            EditCurrencies();
        }

        private void editTransactionTypesButton_Click(object sender, EventArgs e)
        {
            EditTransactionTypes();
        }

        private void editPlacesOfPurchasesButton_Click(object sender, EventArgs e)
        {
            EditPlacesOfPurchases();
        }

        private void editTagsButton_Click(object sender, EventArgs e)
        {
            EditTags();
        }

        private void editCashFacilitiesButton_Click(object sender, EventArgs e)
        {
            EditCashFacilities();
        }

        private void editCategoriesButton_Click(object sender, EventArgs e)
        {
            EditCategories();
        }

        private void editTransactionsButton_Click(object sender, EventArgs e)
        {
            EditTransactions();
        }

        private void analyzeItemsButton_Click(object sender, EventArgs e)
        {
            AnalyzeItems();
        }

        private void currencyApiButton_Click(object sender, EventArgs e)
        {
            SetCurrencyApiKey();
        }

        private void currencyExchangeButton_Click(object sender, EventArgs e)
        {
            CurrencyExchange();
        }

        #endregion

        #region Handlers

        private void EditCurrencies()
        {
            var addCurrenciesForm = new EditCurrenciesForm();
            addCurrenciesForm.Show();
        }

        private void EditTransactionTypes()
        {
            var addTransactionTypesForm = new EditTransactionTypesForm();
            addTransactionTypesForm.Show();
        }

        private void EditPlacesOfPurchases()
        {
            var editPlacesOfPurchasesForm = new EditPlacesOfPurchasesForm();
            editPlacesOfPurchasesForm.Show();
        }

        private void EditTags()
        {
            var editTagsForm = new EditTagsForm();
            editTagsForm.Show();
        }

        private void EditCashFacilities()
        {
            var editCashFacilitiesForm = new EditCashFacilitiesForm();
            editCashFacilitiesForm.Show();
        }

        private void EditCategories()
        {
            var editCategoriesForm = new EditCategoriesForm();
            editCategoriesForm.Show();
        }

        private void EditTransactions()
        {
            var editTransactionsForm = new EditTransactionsForm();
            editTransactionsForm.Show();
        }

        private void AnalyzeItems()
        {
            var analyzeItemsForm = new ViewItemsAnalyticsForm();
            analyzeItemsForm.Show();
        }

        private void SetCurrencyApiKey()
        {
            var setupCurrencyApiForm = new SetupCurrencyApiForm();
            setupCurrencyApiForm.Show();
        }

        private void CurrencyExchange()
        {
            var testCurrencyExchangeForm = new TestCurrencyExchangeForm();
            testCurrencyExchangeForm.Show();
        }

        #endregion
    }
}
