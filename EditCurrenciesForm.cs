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
        private long selectedId = -1;

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
                if (currency.Id == SqliteDataAccess.MainCurrencyId)
                {
                    currenciesListView.Items.Add(
                    new ListViewItem(currency.ItemArray)
                    {
                        Tag = currency.Id,
                        ForeColor = Color.Blue,
                        Font = new Font(currenciesListView.Font, FontStyle.Bold)
                    });
                }
                else
                {
                    currenciesListView.Items.Add(
                    new ListViewItem(currency.ItemArray)
                    {
                        Tag = currency.Id
                    });
                }
            }

            currenciesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            currenciesListView.EndUpdate();
        }

        private void addCurrencyButton_Click(object sender, EventArgs e)
        {
            if (selectedId != -1)
            {
                MessageBox.Show("Please cancel edit before adding a new currency", "Add currency", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CurrencyModel currency = new CurrencyModel
            {
                Name = currencyNameTextBox.Text,
                Code = currencyCodeTextBox.Text,
                Symbol = currencySymbolTextBox.Text,
                Units_Rate = Convert.ToInt32(unitsRateNumericUpDown.Value)
            };

            SqliteDataAccess.AddCurrency(currency);

            clearCurrencyDataView();

            LoadCurrenciesList();
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
            selectedId = Convert.ToInt64(currenciesListView.SelectedItems[0].Tag);

            if (selectedId == SqliteDataAccess.MainCurrencyId)
            {
                MessageBox.Show("You can't edit main currency!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                selectedId = -1;

                return;
            }

            CurrencyModel currency = SqliteDataAccess.GetCurrencyById(selectedId);
            setCurrencyDataView(currency);
        }

        private void saveCurrencyButton_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
                return;

            CurrencyModel currency = new CurrencyModel
            {
                Id = selectedId,
                Name = currencyNameTextBox.Text,
                Code = currencyCodeTextBox.Text,
                Symbol = currencySymbolTextBox.Text,
                Units_Rate = Convert.ToInt32(unitsRateNumericUpDown.Value)
            };

            SqliteDataAccess.UpdateCurrency(currency);

            selectedId = -1;
            clearCurrencyDataView();

            LoadCurrenciesList();
        }

        private void cancelCurrencyEditingButton_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
                return;

            selectedId = -1;
            clearCurrencyDataView();
        }

        private void deleteCurrencyButton_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt64(currenciesListView.SelectedItems[0].Tag);

            if (selectedId == SqliteDataAccess.MainCurrencyId)
            {
                MessageBox.Show("You can't delete main currency!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                selectedId = -1;

                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this currency?", "Delete currency", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                SqliteDataAccess.DeleteCurrencyById(selectedId);

            selectedId = -1;
            clearCurrencyDataView();

            LoadCurrenciesList();
        }
    }
}
