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
            LoadTags();
            LoadData();
            LoadList();
        }

        private void LoadTags()
        {
            var tags = SqliteDataAccess.LoadTags();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = tags;

            tagsCheckedListBox.DataSource = bindingSource.DataSource;
            tagsCheckedListBox.DisplayMember = "Name";
            tagsCheckedListBox.ValueMember = "Id";
        }

        private void LoadData()
        {
            var transaction = SqliteDataAccess.GetTransactionById(transactionId);
            var currency = SqliteDataAccess.GetCurrencyById(transaction.Id_Currency_Of_Transaction);
            var cashFacility = SqliteDataAccess.GetCashFacilityById(transaction.Id_Cash_Facility);

            currencyText = currency.GetMoneyText();
            unitsRate = SqliteDataAccess.GetUnitsRate(cashFacility);

            currencyTextBox.Text = currency.GetFullName();
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

                listView.Items.Add(
                    new ListViewItem(new[] { category.Name, purchase.Sum_By_Transaction.GetString() + " " + currencyText, purchase.Description })
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

        private void setDataView(PurchaseModel purchase)
        {
            purchase.Sum_By_Transaction.Rate = unitsRate;
            categoryId = purchase.Id_Category;

            sumTextBox.Text = purchase.Sum_By_Transaction.GetString();
            categoryTextBox.Text = SqliteDataAccess.GetCategoryById(categoryId).Name;
            descriptionRichTextBox.Text = purchase.Description;
        }

        private void clearDataView()
        {
            sumTextBox.Text = "0";
            categoryTextBox.Clear();
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

            SqliteDataAccess.AddPurchase(purchase);

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
            setDataView(purchase);
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

            SqliteDataAccess.UpdatePurchase(purchase);

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
