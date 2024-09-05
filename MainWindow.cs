using System.Globalization;
using System.Windows.Forms;

namespace FinancialManager
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            updateDBStatus();
            openDBDialog.Filter = "DB files|*.db";
            createDBDialog.Filter = "DB files|*.db";

            // Set the culture to en-GB for correct decimal separator (period instead of comma)
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            TestDbConnection();
        }

        private void updateDBStatus()
        {
            /*
            if (SqliteDataAccess.IsPathToDBCorrect)
                DBStatus.Text = "DB status: CONNECTED";
            else
                DBStatus.Text = "DB status: DISCONNECTED";
            */
        }

        private void openDBButton_Click(object sender, EventArgs e)
        {
            if (openDBDialog.ShowDialog() == DialogResult.Cancel)
                return;

            Properties.Settings.Default.PathToDb = openDBDialog.FileName;

            try
            {
                SqliteDataAccess.TestConnection();

                Properties.Settings.Default.Save();

                MessageBox.Show("Connection to DB successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
            catch
            {
                Properties.Settings.Default.Reload();

                MessageBox.Show("Connection to DB failed!\nPlease choose another DB file or create a new one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void connectToDBButton_Click(object sender, EventArgs e)
        {
            /*
            var result = SqliteDataAccess.TestConnection();
            updateDBStatus();
            MessageBox.Show(result);
            */
        }

        private void disconnectFromDBButton_Click(object sender, EventArgs e)
        {
            /*
            SqliteDataAccess.PathToDB = null;
            SqliteDataAccess.TestConnection();
            updateDBStatus();
            MessageBox.Show("DB closed!");
            */
        }

        private void createDBButton_Click(object sender, EventArgs e)
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
            }
            catch
            {
                Properties.Settings.Default.Reload();

                MessageBox.Show("Creation of DB failed!\nPlease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void editCurrenciesButton_Click(object sender, EventArgs e)
        {
            EditCurrenciesForm addCurrenciesForm = new EditCurrenciesForm();
            addCurrenciesForm.Show();
        }

        private void editTransactionTypesButton_Click(object sender, EventArgs e)
        {
            EditTransactionTypesForm addTransactionTypesForm = new EditTransactionTypesForm();
            addTransactionTypesForm.Show();
        }

        private void editPlacesOfPurchasesButton_Click(object sender, EventArgs e)
        {
            var editPlacesOfPurchasesForm = new EditPlacesOfPurchasesForm();
            editPlacesOfPurchasesForm.Show();
        }

        private void editTagsButton_Click(object sender, EventArgs e)
        {
            var editTagsForm = new EditTagsForm();
            editTagsForm.Show();
        }

        private void editCashFacilitiesButton_Click(object sender, EventArgs e)
        {
            var editCashFacilitiesForm = new EditCashFacilitiesForm();
            editCashFacilitiesForm.Show();
        }

        private void editCategoriesButton_Click(object sender, EventArgs e)
        {
            var editCategoriesForm = new EditCategoriesForm();
            editCategoriesForm.Show();
        }

        private void editTransactionsButton_Click(object sender, EventArgs e)
        {
            var editTransactionsForm = new EditTransactionsForm();
            editTransactionsForm.Show();
        }

        private void currencyApiButton_Click(object sender, EventArgs e)
        {
            var setupCurrencyApiForm = new SetupCurrencyApiForm();
            setupCurrencyApiForm.Show();
        }

        private void currencyExchangeButton_Click(object sender, EventArgs e)
        {
            var testCurrencyExchangeForm = new TestCurrencyExchangeForm();
            testCurrencyExchangeForm.Show();
        }
    }
}
