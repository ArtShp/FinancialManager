using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManager
{
    public partial class SetupCurrencyApiForm : Form
    {
        public SetupCurrencyApiForm()
        {
            InitializeComponent();

            keyTextBox.Text = Properties.Settings.Default.CurrencyApiKey;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (testConnection())
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

        private bool testConnection()
        {
            var res = CurrencyAPI.testConnection(keyTextBox.Text);
            return res;
        }
    }
}
