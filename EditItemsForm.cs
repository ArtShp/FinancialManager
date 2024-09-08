using System.Data;
using System.Text;

namespace FinancialManager
{
    public partial class EditItemsForm : Form
    {
        private long selectedId = -1;
        private long categoryId = -1;
        private long transactionId;
        private long transactionTypeId;
        private CurrencyModel transactionCurrency;
        private DateTime transactionDate;
        private Size originalFormSize;
        private Size originalListViewSize;

        public EditItemsForm(long transactionId)
        {
            this.transactionId = transactionId;

            InitializeComponent();

            LoadAll();

            originalFormSize = new Size(Size.Width, Size.Height);
            originalListViewSize = new Size(listView.Width, listView.Height);
        }

        #region Loaders

        private void LoadAll()
        {
            LoadData();
            LoadTags();
            LoadList();
        }

        private void LoadData()
        {
            var transaction = SqliteDataAccess.GetTransactionById(transactionId);
            transactionCurrency = SqliteDataAccess.GetCurrencyById(transaction.Id_Currency_Of_Transaction);

            transactionTypeId = transaction.Id_Transaction_Type;
            currencyTextBox.Text = transactionCurrency.FullName;
            transactionDate = transaction.Date;
        }

        private void LoadTags()
        {
            var tags = SqliteDataAccess.LoadTags(transactionTypeId);

            tagsListView.BeginUpdate();
            tagsListView.Items.Clear();

            foreach (var tag in tags)
            {
                tagsListView.Items.Add(
                    new ListViewItem(new[] { tag.Name })
                    {
                        Tag = tag.Id
                    });
            }

            tagsListView.EndUpdate();
            tagsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void LoadList()
        {
            var data = SqliteDataAccess.LoadItems(transactionId);

            var mainCurrency = SqliteDataAccess.GetMainCurrency();

            var sum = new MoneyModel(0, transactionCurrency.Units_Rate);
            var sumByMainCurrency = new MoneyModel(0, mainCurrency.Units_Rate);

            listView.BeginUpdate();
            listView.Items.Clear();

            foreach (var item in data)
            {
                var category = SqliteDataAccess.GetCategoryById(item.Id_Category);
                item.Sum.Rate = transactionCurrency.Units_Rate;
                item.Sum_By_Main_Currency.Rate = mainCurrency.Units_Rate;

                var tags = SqliteDataAccess.GetTagsByItemId(item.Id);

                StringBuilder tagsStringBuilder = new StringBuilder();
                foreach (var tag in tags)
                {
                    if (tagsStringBuilder.Length > 0)
                        tagsStringBuilder.Append(", ");

                    tagsStringBuilder.Append(tag.Name);
                }

                var tagsString = tagsStringBuilder.ToString();

                listView.Items.Add(
                    new ListViewItem(new[] { category.Name,
                                             item.Sum.GetString() + " " + transactionCurrency.MoneyText,
                                             item.Sum_By_Main_Currency.GetString() + " " + mainCurrency.MoneyText,
                                             tagsString, item.Description })
                    {
                        Tag = item.Id
                    });

                sum += item.Sum;
                sumByMainCurrency += item.Sum_By_Main_Currency;
            }

            listView.Items.Add(
                new ListViewItem(new[] { "Total",
                                         sum.GetString() + " " + transactionCurrency.MoneyText,
                                         sumByMainCurrency.GetString() + " " + mainCurrency.MoneyText,
                                         "", "" })
                {
                    Tag = -1,
                    Font = new Font(listView.Font, FontStyle.Bold),
                    ForeColor = Color.Blue
                });

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView.EndUpdate();
        }

        #endregion

        #region View Controls

        private void SetDataView(ItemModel item, List<TagModel> tags = null)
        {
            tags ??= new List<TagModel>();

            item.Sum.Rate = transactionCurrency.Units_Rate;
            categoryId = item.Id_Category;

            sumTextBox.Text = item.Sum.GetString();
            categoryTextBox.Text = SqliteDataAccess.GetCategoryById(categoryId).Name;
            foreach (ListViewItem listItem in tagsListView.CheckedItems)
            {
                listItem.Checked = false;
            }
            foreach (var tag in tags)
            {
                var listItem = tagsListView.Items.Cast<ListViewItem>().FirstOrDefault(x => Convert.ToInt64(x.Tag) == tag.Id);
                if (listItem != null)
                    listItem.Checked = true;
            }
            descriptionRichTextBox.Text = item.Description;
        }

        private void ClearDataView()
        {
            sumTextBox.Text = "0";
            categoryTextBox.Clear();
            foreach (ListViewItem item in tagsListView.CheckedItems)
                item.Checked = false;
            descriptionRichTextBox.Clear();

            categoryId = -1;
        }

        #endregion

        #region Buttons Click Handlers

        private void chooseCategoryButton_Click(object sender, EventArgs e)
        {
            if (SqliteDataAccess.GetCategoriesCount() == 0)
            {
                MessageBox.Show("There are no categories to choose from!\nPlease add some categories first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

        private void editButton_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
                return;

            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag);

            if (selectedId == -1)
                return;

            ItemModel item = SqliteDataAccess.GetItemById(selectedId);
            var tags = SqliteDataAccess.GetTagsByItemId(selectedId);
            SetDataView(item, tags);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
                return;

            if (categoryId == -1)
            {
                MessageBox.Show("You haven't chosen category!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var sum = new MoneyModel(sumTextBox.Text, transactionCurrency.Units_Rate);

            try
            {
                var mainCurrency = SqliteDataAccess.GetMainCurrency();
                var convertedSum = CurrencyConverter.ConvertMoney(sum, transactionCurrency, mainCurrency, transactionDate);

                ItemModel item = new ItemModel
                {
                    Id = selectedId,
                    Id_Transaction = transactionId,
                    Sum = sum,
                    Sum_By_Main_Currency = convertedSum,
                    Id_Category = categoryId,
                    Description = descriptionRichTextBox.Text
                };

                var tagsId = tagsListView.CheckedItems.Cast<ListViewItem>().Select(x => Convert.ToInt64(x.Tag)).ToList();

                SqliteDataAccess.UpdateItem(item, tagsId);

                selectedId = -1;
                ClearDataView();

                LoadList();
            }
            catch
            {
                MessageBox.Show("Error while updating item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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
                MessageBox.Show("Please cancel edit before adding a new item", "Add item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (categoryId == -1)
            {
                MessageBox.Show("You haven't chosen category!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var sum = new MoneyModel(sumTextBox.Text, transactionCurrency.Units_Rate);

            try
            {
                var mainCurrency = SqliteDataAccess.GetMainCurrency();
                var convertedSum = CurrencyConverter.ConvertMoney(sum, transactionCurrency, mainCurrency, transactionDate);

                ItemModel item = new ItemModel
                {
                    Id_Transaction = transactionId,
                    Sum = sum,
                    Sum_By_Main_Currency = convertedSum,
                    Id_Category = categoryId,
                    Description = descriptionRichTextBox.Text
                };

                var tagsId = tagsListView.CheckedItems.Cast<ListViewItem>().Select(x => Convert.ToInt64(x.Tag)).ToList();

                SqliteDataAccess.AddItem(item, tagsId);

                ClearDataView();

                LoadList();
            }
            catch
            {
                MessageBox.Show("Error while adding item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
                return;

            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag);

            if (selectedId == -1)
                return;

            var result = MessageBox.Show("Are you sure you want to delete this item?", "Delete item", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                SqliteDataAccess.DeleteItemById(selectedId);

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

        private void EditItemsForm_Resize(object sender, EventArgs e)
        {
            ResizeListView();
        }

        private void EditItemsForm_ResizeEnd(object sender, EventArgs e)
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
    }
}
