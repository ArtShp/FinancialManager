namespace FinancialManager
{
    public partial class SetupCurrencyApiForm : Form
    {
        public SetupCurrencyApiForm()
        {
            InitializeComponent();

            keyTextBox.Text = Properties.Settings.Default.CurrencyApiKey;
        }

        #region Tests

        private bool TestConnection()
        {
            var res = CurrencyAPI.TestConnection(keyTextBox.Text);
            return res;
        }

        #endregion

        #region Buttons Click Handlers

        private void okButton_Click(object sender, EventArgs e)
        {
            if (TestConnection())
            {
                Properties.Settings.Default.CurrencyApiKey = keyTextBox.Text;
                Properties.Settings.Default.Save();

                MessageBox.Show("Connection successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            }
            else
            {
                MessageBox.Show("Connection failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
