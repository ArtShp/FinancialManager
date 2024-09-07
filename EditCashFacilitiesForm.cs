namespace FinancialManager
{
    public partial class EditCashFacilitiesForm : Form
    {
        private long selectedId = -1;

        public EditCashFacilitiesForm()
        {
            InitializeComponent();

            LoadAll();
        }

        #region Loaders

        private void LoadAll()
        {
            LoadCurrencies();
            LoadList();
        }

        private void LoadCurrencies()
        {
            var currencies = SqliteDataAccess.LoadCurrencies();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = currencies;

            currencyComboBox.DataSource = bindingSource.DataSource;
            currencyComboBox.DisplayMember = "Name";
            currencyComboBox.ValueMember = "Id";
        }

        private void LoadList()
        {
            var data = SqliteDataAccess.LoadCashFacilities();

            listView.BeginUpdate();
            listView.Items.Clear();

            foreach (var cashFacility in data)
            {
                var currency = SqliteDataAccess.GetCurrencyById(cashFacility.Id_Currency);
                listView.Items.Add(
                    new ListViewItem(new[] { cashFacility.Name, currency.Name })
                    {
                        Tag = cashFacility.Id
                    });
            }

            listView.EndUpdate();
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        #endregion

        #region View Controls

        private void SetDataView(CashFacilityModel cashFacility)
        {
            nameTextBox.Text = cashFacility.Name;
            currencyComboBox.SelectedValue = cashFacility.Id_Currency;
        }

        private void ClearDataView()
        {
            nameTextBox.Clear();
            currencyComboBox.SelectedIndex = 0;
        }

        #endregion

        #region Buttons Click Handlers

        private void editButton_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag);
            var cashFacility = SqliteDataAccess.GetCashFacilityById(selectedId);
            SetDataView(cashFacility);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
                return;

            CashFacilityModel cashFacility = new CashFacilityModel
            {
                Id = selectedId,
                Name = nameTextBox.Text,
                Id_Currency = Convert.ToInt64(currencyComboBox.SelectedValue)
            };

            SqliteDataAccess.UpdateCashFacility(cashFacility);

            selectedId = -1;
            ClearDataView();

            LoadList();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
                return;

            selectedId = -1;
            ClearDataView();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (selectedId != -1)
            {
                MessageBox.Show("Please cancel edit before adding a new cash facility", "Add cash facility", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CashFacilityModel cashFacility = new CashFacilityModel
            {
                Name = nameTextBox.Text,
                Id_Currency = Convert.ToInt64(currencyComboBox.SelectedValue)
            };

            SqliteDataAccess.AddCashFacility(cashFacility);

            ClearDataView();

            LoadList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag);

            var result = MessageBox.Show("Are you sure you want to delete this cash facility?", "Delete Cash Facility", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                SqliteDataAccess.DeleteCashFacilityById(selectedId);

            selectedId = -1;
            ClearDataView();

            LoadList();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        #endregion
    }
}
