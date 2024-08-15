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
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void updateDBStatus()
        {
            if (SqliteDataAccess.IsPathToDBCorrect)
                DBStatus.Text = "DB status: CONNECTED";
            else
                DBStatus.Text = "DB status: DISCONNECTED";
        }

        private void openDBButton_Click(object sender, EventArgs e)
        {
            if (openDBDialog.ShowDialog() == DialogResult.Cancel)
                return;
            SqliteDataAccess.PathToDB = openDBDialog.FileName;
            MessageBox.Show("DB opened!");
        }

        private void connectToDBButton_Click(object sender, EventArgs e)
        {
            var result = SqliteDataAccess.TestConnection();
            updateDBStatus();
            MessageBox.Show(result);
        }

        private void disconnectFromDBButton_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.PathToDB = null;
            SqliteDataAccess.TestConnection();
            updateDBStatus();
            MessageBox.Show("DB closed!");
        }

        private void createDBButton_Click(object sender, EventArgs e)
        {
            if (createDBDialog.ShowDialog() == DialogResult.Cancel)
                return;
            SqliteDataAccess.PathToDB = createDBDialog.FileName;
            SqliteDataAccess.CreateDB();
            // SqliteDataAccess.TestConnection();
            // updateDBStatus();
            MessageBox.Show("DB created!");
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

        }
    }
}
