namespace FinancialManager
{
    public partial class TestCurrencyExchangeForm : Form
    {
        public TestCurrencyExchangeForm()
        {
            InitializeComponent();

            moneyTextBox.Text = "0";
            dateTimePicker.Value = DateTime.Today;

            LoadAll();
        }

        #region Loaders

        private void LoadAll()
        {
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

        #endregion

        #region Buttons Click Handlers

        private void convertButton_Click(object sender, EventArgs e)
        {
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
    }
}
