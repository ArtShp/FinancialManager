namespace FinancialManager
{
    public partial class ViewItemsAnalyticsForm : Form
    {
        private long categoryId = -1;
        private bool isFromDateSet = false;
        private bool isToDateSet = false;
        private Size originalFormSize;
        private Size originalListViewSize;

        public ViewItemsAnalyticsForm()
        {
            InitializeComponent();

            fromDateTimePicker.Value = DateTime.Today;
            toDateTimePicker.Value = DateTime.Today;

            originalFormSize = new Size(Size.Width, Size.Height);
            originalListViewSize = new Size(listView.Width, listView.Height);

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            LoadAll();
            ClearDates();
        }

        #region Loaders

        private void LoadAll()
        {
            try
            {
                LoadTransactionTypes();
                LoadPlacesOfPurchases();
            }
            catch
            {
                MessageBox.Show("Error while loading data from DB. Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void LoadTransactionTypes()
        {
            var data = SqliteDataAccess.LoadTransactionTypes();
            data.Insert(0, new TransactionTypeModel { Id = -1, Name = "---NONE---" });

            transactionTypeComboBox.DataSource = data;
            transactionTypeComboBox.DisplayMember = "Name";
            transactionTypeComboBox.ValueMember = "Id";
        }

        private void LoadPlacesOfPurchases()
        {
            var data = SqliteDataAccess.LoadPlacesOfPurchases();
            data.Insert(0, new PlaceOfPurchaseModel { Id = -1, Name = "---NONE---" });

            placeComboBox.DataSource = data;
            placeComboBox.DisplayMember = "Name";
            placeComboBox.ValueMember = "Id";
        }

        #endregion

        #region Clear Dates

        // Used to "forget" dates
        private void ClearDates()
        {
            ClearFromDate();
            ClearToDate();
        }

        private void ClearFromDate()
        {
            fromDateTimePicker.CustomFormat = "---NONE---";
            isFromDateSet = false;
        }

        private void ClearToDate()
        {
            toDateTimePicker.CustomFormat = "---NONE---";
            isToDateSet = false;
        }

        #endregion

        #region Buttons Click Handlers

        private void clearFromDateButton_Click(object sender, EventArgs e)
        {
            ClearFromDate();
        }

        private void clearToDateButton_Click(object sender, EventArgs e)
        {
            ClearToDate();
        }

        private void chooseCategoryButton_Click(object sender, EventArgs e)
        {
            var chooseCategoryForm = new ChooseCategoryForm();
            chooseCategoryForm.ShowDialog();

            var selectedCategoryId = chooseCategoryForm.SelectedId;

            if (selectedCategoryId == -1)
                return;

            categoryId = selectedCategoryId;
            categoryTextBox.Text = SqliteDataAccess.GetCategoryById(categoryId).Name;
        }

        private void clearCategoryButton_Click(object sender, EventArgs e)
        {
            categoryId = -1;
            categoryTextBox.Clear();
        }

        private void getButton_Click(object sender, EventArgs e)
        {
            var fromDate = fromDateTimePicker.Value.Date;
            var toDate = toDateTimePicker.Value.Date;

            if (isFromDateSet && isToDateSet && fromDate > toDate)
            {
                MessageBox.Show("Start date can't be greater than end date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var data = SqliteDataAccess.GetItems(categoryId,
                                                     Convert.ToInt64(transactionTypeComboBox.SelectedValue),
                                                     isFromDateSet ? fromDate : null,
                                                     isToDateSet ? toDate : null,
                                                     Convert.ToInt64(placeComboBox.SelectedValue));

            var mainCurrency = SqliteDataAccess.GetMainCurrency();

            var sumIncome = new MoneyModel(0, mainCurrency.Units_Rate);
            var sumExpense = new MoneyModel(0, mainCurrency.Units_Rate);

            var incomeId = SqliteDataAccess.IncomeTransactionTypeId;
            var expenseId = SqliteDataAccess.ExpenseTransactionTypeId;

            listView.BeginUpdate();
            listView.Items.Clear();

            listView.Groups.Add(new ListViewGroup(SqliteDataAccess.GetTransactionTypeById(incomeId).Name, HorizontalAlignment.Left));
            listView.Groups.Add(new ListViewGroup(SqliteDataAccess.GetTransactionTypeById(expenseId).Name, HorizontalAlignment.Left));

            foreach (var item in data)
            {
                var listItem = new ListViewItem(new string[]
                {
                    item.Category,
                    item.Date.ToString("dd.MM.yyyy"),
                    item.Sum.GetString() + " " + item.CurrencyText,
                    item.SumByMainCurrency.GetString() + " " + mainCurrency.MoneyText,
                    item.Place,
                    item.Tags
                });

                listView.Items.Add(listItem);
                if (item.TransactionTypeId == incomeId)
                {
                    listView.Groups[incomeId - 1].Items.Add(listItem);
                    sumIncome += item.SumByMainCurrency;
                }
                else if (item.TransactionTypeId == expenseId)
                {
                    listView.Groups[expenseId - 1].Items.Add(listItem);
                    sumExpense += item.SumByMainCurrency;
                }
            }

            var incomeItem = new ListViewItem(new string[]
            {
                $"Total: {listView.Groups[incomeId - 1].Items.Count} of {SqliteDataAccess.GetItemsCount(incomeId)}",
                "",
                "",
                sumIncome.GetString() + " " + mainCurrency.MoneyText,
                "",
                ""
            })
            {
                Tag = -1,
                Font = new Font(listView.Font, FontStyle.Bold),
                ForeColor = Color.Blue
            };

            var expenseItem = new ListViewItem(new string[]
            {
                $"Total: {listView.Groups[expenseId - 1].Items.Count} of {SqliteDataAccess.GetItemsCount(expenseId)}",
                "",
                "",
                sumExpense.GetString() + " " + mainCurrency.MoneyText,
                "",
                ""
            })
            {
                Tag = -1,
                Font = new Font(listView.Font, FontStyle.Bold),
                ForeColor = Color.OrangeRed
            };

            listView.Items.Add(incomeItem);
            listView.Items.Add(expenseItem);

            listView.Groups[incomeId - 1].Items.Add(incomeItem);
            listView.Groups[expenseId - 1].Items.Add(expenseItem);

            listView.EndUpdate();
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        #endregion

        #region Resize Handlers

        private void ViewItemsAnalyticsForm_Resize(object sender, EventArgs e)
        {
            ResizeListView();
        }

        private void ViewItemsAnalyticsForm_ResizeEnd(object sender, EventArgs e)
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

        // Used to "choose" dates
        private void fromDateTimePicker_DropDown(object sender, EventArgs e)
        {
            fromDateTimePicker.CustomFormat = "dd.MM.yyyy";
            isFromDateSet = true;
        }

        private void toDateTimePicker_DropDown(object sender, EventArgs e)
        {
            toDateTimePicker.CustomFormat = "dd.MM.yyyy";
            isToDateSet = true;
        }

        #endregion
    }
}
