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

        private void button1_Click(object sender, EventArgs e)
        {
            if (openDBDialog.ShowDialog() == DialogResult.Cancel)
                return;
            SqliteDataAccess.PathToDB = openDBDialog.FileName;
            MessageBox.Show("DB opened!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = SqliteDataAccess.TestConnection();
            updateDBStatus();
            MessageBox.Show(result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.PathToDB = null;
            SqliteDataAccess.TestConnection();
            updateDBStatus();
            MessageBox.Show("DB closed!");
        }
    }
}
