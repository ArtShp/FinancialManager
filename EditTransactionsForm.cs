using System.Text.RegularExpressions;

namespace FinancialManager
{
    public partial class EditTransactionsForm : Form
    {
        private long selectedId = -1;
        private Size originalFormSize;
        private Size originalListViewSize;

        public EditTransactionsForm()
        {
            InitializeComponent();

            LoadAll();

            originalFormSize = new Size(Size.Width, Size.Height);
            originalListViewSize = new Size(listView.Width, listView.Height);

            sumErrorProvider.ContainerControl = this;
        }

        #region Loaders

        private void LoadAll()
        {
            LoadCurrentDate();
            LoadTransactionTypes();
            LoadCurrencies();
            LoadCashFacilities();
            LoadPlacesOfPurchases();
            LoadList();
        }

        private void LoadCurrentDate()
        {
            dateTimePicker.Value = DateTime.Today;
        }

        private void LoadTransactionTypes()
        {
            var transactionTypes = SqliteDataAccess.LoadTransactionTypes();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = transactionTypes;

            transactionComboBox.DataSource = bindingSource.DataSource;
            transactionComboBox.DisplayMember = "Name";
            transactionComboBox.ValueMember = "Id";
        }

        private void LoadCurrencies()
        {
            var currencies = SqliteDataAccess.LoadCurrencies();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = currencies;

            currencyComboBox.DataSource = bindingSource.DataSource;
            currencyComboBox.DisplayMember = "Code";
            currencyComboBox.ValueMember = "Id";
        }

        private void LoadCashFacilities()
        {
            var cashFacilities = SqliteDataAccess.LoadCashFacilities();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = cashFacilities;

            cashComboBox.DataSource = bindingSource.DataSource;
            cashComboBox.DisplayMember = "Name";
            cashComboBox.ValueMember = "Id";
        }

        private void LoadPlacesOfPurchases()
        {
            var placesOfPurchases = new List<PlaceOfPurchaseModel> {
                new PlaceOfPurchaseModel { Id = 0, Name = "---NONE---" }
            };
            placesOfPurchases.AddRange(SqliteDataAccess.LoadPlacesOfPurchases());

            var bindingSource = new BindingSource();
            bindingSource.DataSource = placesOfPurchases;

            placeComboBox.DataSource = bindingSource.DataSource;
            placeComboBox.DisplayMember = "Name";
            placeComboBox.ValueMember = "Id";
        }

        private void LoadList()
        {
            var data = SqliteDataAccess.LoadTransactions();

            listView.BeginUpdate();
            listView.Items.Clear();

            foreach (var transaction in data)
            {
                var transactionType = SqliteDataAccess.GetTransactionTypeById(transaction.Id_Transaction_Type);
                var currency = SqliteDataAccess.GetCurrencyById(transaction.Id_Currency_Of_Transaction);
                var cashFacility = SqliteDataAccess.GetCashFacilityById(transaction.Id_Cash_Facility);

                transaction.Sum_By_Cash_Facility.Rate = SqliteDataAccess.GetUnitsRate(cashFacility);

                var cashFacilityCurrency = SqliteDataAccess.GetCurrencyById(cashFacility.Id_Currency);
                var currencyText = cashFacilityCurrency.MoneyText;

                string place = "";
                if (transaction.Id_Place_Of_Purchase != 0)
                {
                    place = SqliteDataAccess.GetPlaceOfPurchaseById(transaction.Id_Place_Of_Purchase).Name;
                }

                listView.Items.Add(
                    new ListViewItem(new[] { transactionType.Name, transaction.Date.ToString("dd.MM.yyyy"), transaction.Sum_By_Cash_Facility.GetString() + " " + currencyText, currency.Code, cashFacility.Name, place, transaction.Description })
                    {
                        Tag = transaction.Id
                    });
            }

            listView.EndUpdate();
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        #endregion

        #region View Controls

        private void SetDataView(TransactionModel transaction)
        {
            transaction.Sum_By_Cash_Facility.Rate = SqliteDataAccess.GetUnitsRate(transaction.Id_Cash_Facility);

            transactionComboBox.SelectedValue = transaction.Id_Transaction_Type;
            dateTimePicker.Value = transaction.Date;
            sumTextBox.Text = transaction.Sum_By_Cash_Facility.GetString();
            currencyComboBox.SelectedValue = transaction.Id_Currency_Of_Transaction;
            cashComboBox.SelectedValue = transaction.Id_Cash_Facility;
            placeComboBox.SelectedValue = transaction.Id_Place_Of_Purchase;
            descriptionRichTextBox.Text = transaction.Description;
        }

        private void ClearDataView()
        {
            transactionComboBox.SelectedIndex = 0;
            dateTimePicker.Value = DateTime.Now;
            sumTextBox.Text = "0";
            currencyComboBox.SelectedIndex = 0;
            cashComboBox.SelectedIndex = 0;
            placeComboBox.SelectedIndex = 0;
            descriptionRichTextBox.Clear();
        }

        #endregion

        #region Buttons Click Handlers

        private void editButton_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
                return;

            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag);
            TransactionModel transaction = SqliteDataAccess.GetTransactionById(selectedId);
            SetDataView(transaction);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
                return;

            if (!ValidateSum())
                return;

            var idCashFacility = Convert.ToInt64(cashComboBox.SelectedValue);

            TransactionModel transaction = new TransactionModel
            {
                Id = selectedId,
                Id_Transaction_Type = Convert.ToInt64(transactionComboBox.SelectedValue),
                Date = dateTimePicker.Value.Date,
                Sum_By_Cash_Facility = new MoneyModel(sumTextBox.Text, SqliteDataAccess.GetUnitsRate(idCashFacility)),
                Id_Currency_Of_Transaction = Convert.ToInt64(currencyComboBox.SelectedValue),
                Id_Cash_Facility = idCashFacility,
                Id_Place_Of_Purchase = Convert.ToInt64(placeComboBox.SelectedValue),
                Description = descriptionRichTextBox.Text
            };

            SqliteDataAccess.UpdateTransaction(transaction);

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
                MessageBox.Show("Please cancel edit before adding a new transaction", "Add transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidateSum())
                return;

            var idCashFacility = Convert.ToInt64(cashComboBox.SelectedValue);

            TransactionModel transaction = new TransactionModel
            {
                Id_Transaction_Type = Convert.ToInt64(transactionComboBox.SelectedValue),
                Date = dateTimePicker.Value.Date,
                Sum_By_Cash_Facility = new MoneyModel(sumTextBox.Text, SqliteDataAccess.GetUnitsRate(idCashFacility)),
                Id_Currency_Of_Transaction = Convert.ToInt64(currencyComboBox.SelectedValue),
                Id_Cash_Facility = idCashFacility,
                Id_Place_Of_Purchase = Convert.ToInt64(placeComboBox.SelectedValue),
                Description = descriptionRichTextBox.Text
            };

            SqliteDataAccess.AddTransaction(transaction);

            ClearDataView();

            LoadList();

            var editItemsForm = new EditItemsForm(SqliteDataAccess.GetLastAddedTransactionId());
            editItemsForm.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
                return;

            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag);

            var result = MessageBox.Show("Are you sure you want to delete this transaction?", "Delete Transaction", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                SqliteDataAccess.DeleteTransactionById(selectedId);

            selectedId = -1;
            ClearDataView();

            LoadList();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        #endregion

        #region Resize Handlers

        private void EditTransactionsForm_Resize(object sender, EventArgs e)
        {
            ResizeListView();
        }

        private void EditTransactionsForm_ResizeEnd(object sender, EventArgs e)
        {
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ResizeListView()
        {
            // Resize listView to fit the form
            listView.Size = new Size(originalListViewSize.Width + (Width - originalFormSize.Width),
                                     originalListViewSize.Height + (Height - originalFormSize.Height));
        }

        #endregion

        #region Other Controls Handlers

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > 0)
            {
                selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag);

                var editItemsForm = new EditItemsForm(selectedId);
                editItemsForm.Show();
            }
        }

        private void sumTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateSum();
        }

        private bool ValidateSum()
        {
            var status = true;

            if (Regex.IsMatch(sumTextBox.Text, @"^(\d+\.\d+|\d+)$"))
            {
                sumErrorProvider.SetError(sumTextBox, "");
            }
            else
            {
                sumErrorProvider.SetError(sumTextBox, "Please enter a valid number!");
                status = false;
            }

            return status;
        }

        #endregion
    }
}
