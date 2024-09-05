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
            currenciesListView.BeginUpdate();
            currenciesListView.Items.Clear();

            foreach (var currency in data)
            {
                currenciesListView.Items.Add(
                    new ListViewItem(currency.ItemArray)
                    {
                        Tag = currency.Id
                    });
            }
            currenciesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            currenciesListView.EndUpdate();
        }

        private void addCurrencyButton_Click(object sender, EventArgs e)
        {
            CurrencyModel currency = new CurrencyModel
            {
                Name = currencyNameTextBox.Text,
                Code = currencyCodeTextBox.Text,
                Symbol = currencySymbolTextBox.Text,
                Units_Rate = Convert.ToInt32(unitsRateNumericUpDown.Value)
            };

            SqliteDataAccess.AddCurrency(currency);

            clearCurrencyDataView();
        }

        private void setCurrencyDataView(CurrencyModel currency)
        {
            currencyNameTextBox.Text = currency.Name;
            currencyCodeTextBox.Text = currency.Code;
            currencySymbolTextBox.Text = currency.Symbol;
            unitsRateNumericUpDown.Value = currency.Units_Rate;
        }

        private void clearCurrencyDataView()
        {
            currencyNameTextBox.Clear();
            currencyCodeTextBox.Clear();
            currencySymbolTextBox.Clear();
            unitsRateNumericUpDown.Value = 0;
        }

        private void refreshCurrenciesButton_Click(object sender, EventArgs e)
        {
            LoadCurrenciesList();
        }

        private void editCurrencyButton_Click(object sender, EventArgs e)
        {
            selectedCurrencyId = Convert.ToInt64(currenciesListView.SelectedItems[0].Tag);

            if (selectedCurrencyId == SqliteDataAccess.MainCurrencyId)
            {
                MessageBox.Show("You can't edit main currency!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                selectedCurrencyId = -1;

                return;
            }

            CurrencyModel currency = SqliteDataAccess.GetCurrencyById(selectedCurrencyId);
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
                Symbol = currencySymbolTextBox.Text,
                Units_Rate = Convert.ToInt32(unitsRateNumericUpDown.Value)
            };

            SqliteDataAccess.UpdateCurrency(currency);

            selectedCurrencyId = -1;
            clearCurrencyDataView();
        }

        private void cancelCurrencyEditingButton_Click(object sender, EventArgs e)
        {
            if (selectedCurrencyId == -1)
                return;

            selectedCurrencyId = -1;
            clearCurrencyDataView();
        }

        private void deleteCurrencyButton_Click(object sender, EventArgs e)
        {
            selectedCurrencyId = Convert.ToInt64(currenciesListView.SelectedItems[0].Tag.ToString());

            var result = MessageBox.Show("Are you sure you want to delete this currency?", "Delete currency", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                SqliteDataAccess.DeleteCurrencyById(selectedCurrencyId);

            selectedCurrencyId = -1;
            clearCurrencyDataView();
        }
    }
}
