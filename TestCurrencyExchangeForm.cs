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
    public partial class TestCurrencyExchangeForm : Form
    {
        public TestCurrencyExchangeForm()
        {
            InitializeComponent();

            moneyTextBox.Text = "0";
            dateTimePicker.Value = DateTime.Today;

            LoadCurrencies();
        }

        private void LoadCurrencies()
        {
            var fromCurrencies = SqliteDataAccess.LoadCurrencies();
            var toCurrencies = new List<CurrencyModel>(fromCurrencies);
            var fromBindingSource = new BindingSource();
            var toBindingSource = new BindingSource();
            fromBindingSource.DataSource = fromCurrencies;
            toBindingSource.DataSource = toCurrencies;

            fromCurrencyComboBox.DataSource = fromBindingSource.DataSource;
            fromCurrencyComboBox.DisplayMember = "FullName";
            fromCurrencyComboBox.ValueMember = "Id";

            toCurrencyComboBox.DataSource = toBindingSource.DataSource;
            toCurrencyComboBox.DisplayMember = "FullName";
            toCurrencyComboBox.ValueMember = "Id";
        }
    }
}
