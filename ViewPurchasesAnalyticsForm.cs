namespace FinancialManager
{
    public partial class ViewPurchasesAnalyticsForm : Form
    {
        private long categoryId = -1;
        private bool isFromDateSet = false;
        private bool isToDateSet = false;

        public ViewPurchasesAnalyticsForm()
        {
            InitializeComponent();

            LoadAll();
            ClearFromDate();
            ClearToDate();

            fromDateTimePicker.Value = DateTime.Today;
            toDateTimePicker.Value = DateTime.Today;

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void LoadAll()
        {
            LoadTransactionTypes();
            LoadPlacesOfPurchases();
        }

        private void LoadTransactionTypes()
        {
            var data = SqliteDataAccess.LoadTransactionTypes();
            data.Insert(0, new TransactionTypeModel { Id = -1, Name = "" });

            transactionTypeComboBox.DataSource = data;
            transactionTypeComboBox.DisplayMember = "Name";
            transactionTypeComboBox.ValueMember = "Id";
        }

        private void LoadPlacesOfPurchases()
        {
            var data = SqliteDataAccess.LoadPlacesOfPurchases();
            data.Insert(0, new PlaceOfPurchaseModel { Id = -1, Name = "" });

            placeComboBox.DataSource = data;
            placeComboBox.DisplayMember = "Name";
            placeComboBox.ValueMember = "Id";
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

            var selectedCategoryId = chooseCategoryForm.GetSelectedId();

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

            var data = SqliteDataAccess.GetPurchases(categoryId, 
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

            foreach (var purchase in data)
            {
                var item = new ListViewItem(new string[]
                {
                    purchase.Category,
                    purchase.Date.ToString("dd.MM.yyyy"),
                    purchase.Sum.GetString() + " " + purchase.CurrencyText,
                    purchase.SumByMainCurrency.GetString() + " " + mainCurrency.MoneyText,
                    purchase.Place,
                    purchase.Tags
                });

                listView.Items.Add(item);
                if (purchase.TransactionTypeId == incomeId)
                {
                    listView.Groups[incomeId - 1].Items.Add(item);
                    sumIncome += purchase.SumByMainCurrency;
                }
                else if (purchase.TransactionTypeId == expenseId)
                {
                    listView.Groups[expenseId - 1].Items.Add(item);
                    sumExpense += purchase.SumByMainCurrency;
                }
            }

            var incomeItem = new ListViewItem(new string[]
            {
                $"Total: {listView.Groups[incomeId - 1].Items.Count} of {SqliteDataAccess.GetPurchasesCount(incomeId)}",
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
                $"Total: {listView.Groups[expenseId - 1].Items.Count} of {SqliteDataAccess.GetPurchasesCount(expenseId)}",
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
    }
}
