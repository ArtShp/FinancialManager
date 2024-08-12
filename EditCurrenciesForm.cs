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
    public partial class EditCurrenciesForm : Form
    {
        private List<CurrencyModel> data = new List<CurrencyModel>();

        public EditCurrenciesForm()
        {
            InitializeComponent();

            LoadCurrenciesList();
        }

        private void LoadCurrenciesList()
        {
            data = SqliteDataAccess.LoadCurrencies();

            UpdateCurrenciesList();
        }

        private void UpdateCurrenciesList()
        {
            currenciesListBox.DataSource = data;
            currenciesListBox.DisplayMember = "Display";
        }

        private void addCurrencyButton_Click(object sender, EventArgs e)
        {
            CurrencyModel currency = new CurrencyModel
            {
                Name = currencyNameTextBox.Text,
                Code = currencyCodeTextBox.Text,
                Symbol = currencySymbolTextBox.Text
            };

            SqliteDataAccess.SaveCurrency(currency);

            currencyNameTextBox.Clear();
            currencyCodeTextBox.Clear();
            currencySymbolTextBox.Clear();
        }

        private void refreshCurrenciesButton_Click(object sender, EventArgs e)
        {
            LoadCurrenciesList();
        }
    }
}
