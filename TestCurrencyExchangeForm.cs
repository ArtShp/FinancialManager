using System.Text.RegularExpressions;

namespace FinancialManager
{
    public partial class TestCurrencyExchangeForm : Form
    {
        public TestCurrencyExchangeForm()
        {
            InitializeComponent();

            LoadAll();

            moneyTextBox.Text = "0";
            dateTimePicker.Value = DateTime.Today;

            sumErrorProvider.ContainerControl = this;
        }

        #region Loaders

        private void LoadAll()
        {
            try
            {
                LoadCurrencies();
            }
            catch
            {
                MessageBox.Show("Error while loading data from DB. Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
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

        #endregion

        #region Buttons Click Handlers

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (!ValidateSum())
                return;

            try
            {
                var fromCurrency = SqliteDataAccess.GetCurrencyById(Convert.ToInt64(fromCurrencyComboBox.SelectedValue));
                var toCurrency = SqliteDataAccess.GetCurrencyById(Convert.ToInt64(toCurrencyComboBox.SelectedValue));

                var money = new MoneyModel(moneyTextBox.Text, fromCurrency.Units_Rate);
                var convertedMoney = CurrencyConverter.ConvertMoney(money, fromCurrency, toCurrency, dateTimePicker.Value);

                string message = $"Convertation:\n{money.GetString()} {fromCurrency.Code} = {convertedMoney.GetString()} {toCurrency.Code}\n{dateTimePicker.Value.ToString("dd.MM.yyyy")}";

                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Other Controls Handlers

        private void moneyTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateSum();
        }

        private bool ValidateSum()
        {
            var status = true;

            if (Regex.IsMatch(moneyTextBox.Text, @"^(\d+\.\d+|\d+)$"))
            {
                sumErrorProvider.SetError(moneyTextBox, "");
            }
            else
            {
                sumErrorProvider.SetError(moneyTextBox, "Please enter a valid number!");
                status = false;
            }

            return status;
        }

        #endregion
    }
}
