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
        private long selectedCurrencyId = -1;

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
            currenciesListBox.ValueMember = "Id";
        }

        private void addCurrencyButton_Click(object sender, EventArgs e)
        {
            CurrencyModel currency = new CurrencyModel
            {
                Name = currencyNameTextBox.Text,
                Code = currencyCodeTextBox.Text,
                Symbol = currencySymbolTextBox.Text
            };

            SqliteDataAccess.AddCurrency(currency);

            clearCurrencyDataView();
        }

        private void setCurrencyDataView(CurrencyModel currency)
        {
            currencyNameTextBox.Text = currency.Name;
            currencyCodeTextBox.Text = currency.Code;
            currencySymbolTextBox.Text = currency.Symbol;
        }

        private void clearCurrencyDataView()
        {
            currencyNameTextBox.Clear();
            currencyCodeTextBox.Clear();
            currencySymbolTextBox.Clear();
        }

        private void refreshCurrenciesButton_Click(object sender, EventArgs e)
        {
            LoadCurrenciesList();
        }

        private void editCurrencyButton_Click(object sender, EventArgs e)
        {
            CurrencyModel currency = (CurrencyModel)currenciesListBox.SelectedItem;
            selectedCurrencyId = (long)currenciesListBox.SelectedValue;
            setCurrencyDataView(currency);
        }

        private void saveCurrencyButton_Click(object sender, EventArgs e)
        {
            if (selectedCurrencyId == -1)
                return;

            CurrencyModel currency = new CurrencyModel
            {
                Id = selectedCurrencyId,
                Name = currencyNameTextBox.Text,
                Code = currencyCodeTextBox.Text,
                Symbol = currencySymbolTextBox.Text
            };

            SqliteDataAccess.UpdateCurrency(currency);

            selectedCurrencyId = -1;
            clearCurrencyDataView();
        }

        private void currenciesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CurrencyModel currency = (CurrencyModel)currenciesListBox.SelectedItem;
        }
    }
}
