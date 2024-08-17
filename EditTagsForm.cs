using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManager
{
    public partial class EditTagsForm : Form
    {
        private List<TagModel> data = new List<TagModel>();
        private long selectedId = -1;

        public EditTagsForm()
        {
            InitializeComponent();

            LoadTransactionTypes();

            LoadList();
        }

        private void LoadTransactionTypes()
        {
            var transactionTypes = SqliteDataAccess.LoadTransactionTypes();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = transactionTypes;

            transactionTypeComboBox.DataSource = bindingSource.DataSource;
            transactionTypeComboBox.DisplayMember = "Name";
            transactionTypeComboBox.ValueMember = "Id";
        }

        private void LoadList()
        {
            data = SqliteDataAccess.LoadTags();

            UpdateList();
        }

        private void UpdateList()
        {
            listView.BeginUpdate();
            listView.Items.Clear();

            foreach (var tag in data)
            {
                var transactionType = SqliteDataAccess.GetTransactionTypeById(tag.Id_Transaction_Type);
                listView.Items.Add(
                    new ListViewItem(new[] { tag.Name, transactionType.Name })
                    {
                        Tag = tag.Id
                    });
            }
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView.EndUpdate();
        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        private void setPlaceOfPurchaseDataView(PlaceOfPurchaseModel placeOfPurchase)
        {
            nameTextBox.Text = placeOfPurchase.Name;
        }

        private void clearDataView()
        {
            nameTextBox.Clear();
        }
    }
}
