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
                var result = MessageBox.Show("Connection failed.\nDo you still want to keep changes?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                
                if (result == DialogResult.Yes)
                {
                    Properties.Settings.Default.CurrencyApiKey = keyTextBox.Text;
                    Properties.Settings.Default.Save();

                    Close();
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
