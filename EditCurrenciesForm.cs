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
            listView.BeginUpdate();
            listView.Items.Clear();

            foreach (var currency in data)
            {
                if (currency.Id == SqliteDataAccess.MainCurrencyId)
                {
                    listView.Items.Add(
                    new ListViewItem(currency.ItemArray)
                    {
                        Tag = currency.Id,
                        ForeColor = Color.Blue,
                        Font = new Font(listView.Font, FontStyle.Bold)
                    });
                }
                else
                {
                    listView.Items.Add(
                    new ListViewItem(currency.ItemArray)
                    {
                        Tag = currency.Id
                    });
                }
            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView.EndUpdate();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (selectedId != -1)
            {
                MessageBox.Show("Please cancel edit before adding a new currency", "Add currency", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CurrencyModel currency = new CurrencyModel
            {
                Name = nameTextBox.Text,
                Code = codeTextBox.Text,
                Symbol = symbolTextBox.Text,
                Units_Rate = Convert.ToInt32(unitsRateNumericUpDown.Value)
            };

            SqliteDataAccess.AddCurrency(currency);

            clearCurrencyDataView();

            LoadCurrenciesList();
        }

        private void setCurrencyDataView(CurrencyModel currency)
        {
            nameTextBox.Text = currency.Name;
            codeTextBox.Text = currency.Code;
            symbolTextBox.Text = currency.Symbol;
            unitsRateNumericUpDown.Value = currency.Units_Rate;
        }

        private void clearCurrencyDataView()
        {
            nameTextBox.Clear();
            codeTextBox.Clear();
            symbolTextBox.Clear();
            unitsRateNumericUpDown.Value = 0;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadCurrenciesList();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag);

            if (selectedId == SqliteDataAccess.MainCurrencyId)
            {
                MessageBox.Show("You can't edit main currency!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                selectedId = -1;

                return;
            }

            CurrencyModel currency = SqliteDataAccess.GetCurrencyById(selectedId);
            setCurrencyDataView(currency);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
                return;

            CurrencyModel currency = new CurrencyModel
            {
                Id = selectedId,
                Name = nameTextBox.Text,
                Code = codeTextBox.Text,
                Symbol = symbolTextBox.Text,
                Units_Rate = Convert.ToInt32(unitsRateNumericUpDown.Value)
            };

            SqliteDataAccess.UpdateCurrency(currency);

            selectedId = -1;
            clearCurrencyDataView();

            LoadCurrenciesList();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
                return;

            selectedId = -1;
            clearCurrencyDataView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag);

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
