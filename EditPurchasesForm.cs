using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace FinancialManager
{
    public partial class EditPurchasesForm : Form
    {
        private List<PurchaseModel> data = new List<PurchaseModel>();
        private long selectedId = -1;
        private long categoryId = -1;
        private long transactionId;
        private long transactionTypeId;
        private int unitsRate;
        private string currencyText;

        public EditPurchasesForm(long transactionId)
        {
            this.transactionId = transactionId;

            InitializeComponent();

            LoadAll();
        }

        private void LoadAll()
        {
            LoadData();
            LoadTags();
            LoadList();
        }

        private void LoadData()
        {
            var transaction = SqliteDataAccess.GetTransactionById(transactionId);
            var currency = SqliteDataAccess.GetCurrencyById(transaction.Id_Currency_Of_Transaction);

            transactionTypeId = transaction.Id_Transaction_Type;

            currencyText = currency.GetMoneyText();
            unitsRate = currency.Units_Rate;

            currencyTextBox.Text = currency.GetFullName();
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
        }

        private void LoadList()
        {
            data = SqliteDataAccess.LoadPurchases(transactionId);

            UpdateList();
        }

        private void UpdateList()
        {
            listView.BeginUpdate();
            listView.Items.Clear();

            foreach (var purchase in data)
            {
                var category = SqliteDataAccess.GetCategoryById(purchase.Id_Category);
                purchase.Sum_By_Transaction.Rate = unitsRate;

                var tags = SqliteDataAccess.GetTagsByPurchaseId(purchase.Id);

                StringBuilder tagsStringBuilder = new StringBuilder();
                foreach (var tag in tags)
                {
                    if (tagsStringBuilder.Length > 0)
                        tagsStringBuilder.Append(", ");

                    tagsStringBuilder.Append(tag.Name);
                }

                var tagsString = tagsStringBuilder.ToString();

                listView.Items.Add(
                    new ListViewItem(new[] { category.Name, purchase.Sum_By_Transaction.GetString() + " " + currencyText, tagsString, purchase.Description })
                    {
                        Tag = purchase.Id
                    });
            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView.EndUpdate();
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

        private void setDataView(PurchaseModel purchase, List<TagModel> tags = null)
        {
            tags ??= new List<TagModel>();

            purchase.Sum_By_Transaction.Rate = unitsRate;
            categoryId = purchase.Id_Category;

            sumTextBox.Text = purchase.Sum_By_Transaction.GetString();
            categoryTextBox.Text = SqliteDataAccess.GetCategoryById(categoryId).Name;
            foreach (ListViewItem item in tagsListView.CheckedItems)
            {
                item.Checked = false;
            }
            foreach (var tag in tags)
            {
                var item = tagsListView.Items.Cast<ListViewItem>().FirstOrDefault(x => Convert.ToInt64(x.Tag) == tag.Id);
                if (item != null)
                    item.Checked = true;
            }
            descriptionRichTextBox.Text = purchase.Description;
        }

        private void clearDataView()
        {
            sumTextBox.Text = "0";
            categoryTextBox.Clear();
            foreach (ListViewItem item in tagsListView.CheckedItems)
                item.Checked = false;
            descriptionRichTextBox.Clear();

            categoryId = -1;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (categoryId == -1)
            {
                MessageBox.Show("You haven't chosen category!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PurchaseModel purchase = new PurchaseModel
            {
                Id_Transaction = transactionId,
                Sum_By_Transaction = new MoneyModel
                (
                    sumTextBox.Text,
                    unitsRate
                ),
                Id_Category = categoryId,
                Description = descriptionRichTextBox.Text
            };

            var tagsId = tagsListView.CheckedItems.Cast<ListViewItem>().Select(x => Convert.ToInt64(x.Tag)).ToList();

            SqliteDataAccess.AddPurchase(purchase, tagsId);

            clearDataView();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag);

            var result = MessageBox.Show("Are you sure you want to delete this purchase?", "Delete Purchase", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                SqliteDataAccess.DeletePurchaseById(selectedId);

            selectedId = -1;
            clearDataView();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag);
            PurchaseModel purchase = SqliteDataAccess.GetPurchaseById(selectedId);
            var tags = SqliteDataAccess.GetTagsByPurchaseId(selectedId);
            setDataView(purchase, tags);
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

            PurchaseModel purchase = new PurchaseModel
            {
                Id = selectedId,
                Id_Transaction = transactionId,
                Sum_By_Transaction = new MoneyModel
                (
                    sumTextBox.Text,
                    unitsRate
                ),
                Id_Category = categoryId,
                Description = descriptionRichTextBox.Text
            };

            var tagsId = tagsListView.CheckedItems.Cast<ListViewItem>().Select(x => Convert.ToInt64(x.Tag)).ToList();

            SqliteDataAccess.UpdatePurchase(purchase, tagsId);

            selectedId = -1;
            clearDataView();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
                return;

            selectedId = -1;
            clearDataView();
        }
    }
}
