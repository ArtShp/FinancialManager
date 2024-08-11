namespace FinancialManager
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            SqliteDataAccess.DBName = "TestDB.db";
            var res = SqliteDataAccess.TestConnection();
            MessageBox.Show(res.ToString());
        }
    }
}
