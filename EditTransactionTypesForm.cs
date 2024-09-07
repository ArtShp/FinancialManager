using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinancialManager
{
    public partial class EditTransactionTypesForm : Form
    {
        private List<TransactionTypeModel> data = new List<TransactionTypeModel>();
        private long selectedId = -1;

        public EditTransactionTypesForm()
        {
            InitializeComponent();

            addButton.Enabled = false;
            deleteButton.Enabled = false;

            LoadList();
        }

        private void LoadList()
        {
            data = SqliteDataAccess.LoadTransactionTypes();

            UpdateList();
        }

        private void UpdateList()
        {
            listView.BeginUpdate();
            listView.Items.Clear();

            foreach (var transactionType in data)
            {
                listView.Items.Add(
                    new ListViewItem(transactionType.ItemArray)
                    {
                        Tag = transactionType.Id
                    });
            }
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView.EndUpdate();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag.ToString());
            TransactionTypeModel transactionType = SqliteDataAccess.GetTransactionTypeById(selectedId);
            setTransactionTypeDataView(transactionType);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (selectedId != -1)
            {
                MessageBox.Show("Please cancel edit before adding a new transaction type", "Add transaction type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TransactionTypeModel transactionType = new TransactionTypeModel
            {
                Name = nameTextBox.Text
            };

            SqliteDataAccess.AddTransactionType(transactionType);

            clearDataView();

            LoadList();
        }

        private void setTransactionTypeDataView(TransactionTypeModel transactionType)
        {
            nameTextBox.Text = transactionType.Name;
        }

        private void clearDataView()
        {
            nameTextBox.Clear();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
                return;

            TransactionTypeModel transactionType = new TransactionTypeModel
            {
                Id = selectedId,
                Name = nameTextBox.Text
            };

            SqliteDataAccess.UpdateTransactionType(transactionType);

            selectedId = -1;
            clearDataView();

            LoadList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag.ToString());

            var result = MessageBox.Show("Are you sure you want to delete this transaction type?", "Delete transaction type", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                SqliteDataAccess.DeleteTransactionTypeById(selectedId);

            selectedId = -1;
            clearDataView();

            LoadList();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
                return;

            selectedId = -1;
            clearDataView();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadList();
        }
    }
}
