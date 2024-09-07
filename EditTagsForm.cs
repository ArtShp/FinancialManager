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
            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag.ToString());
            TagModel tag = SqliteDataAccess.GetTagById(selectedId);
            setTagDataView(tag);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
                return;

            TagModel tag = new TagModel
            {
                Id = selectedId,
                Name = nameTextBox.Text,
                Id_Transaction_Type = Convert.ToInt64(transactionTypeComboBox.SelectedValue)
            };

            SqliteDataAccess.UpdateTag(tag);

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

        private void addButton_Click(object sender, EventArgs e)
        {
            TagModel tag = new TagModel
            {
                Name = nameTextBox.Text,
                Id_Transaction_Type = Convert.ToInt64(transactionTypeComboBox.SelectedValue)
            };

            SqliteDataAccess.AddTag(tag);

            clearDataView();

            LoadList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag.ToString());

            var result = MessageBox.Show("Are you sure you want to delete this tag?", "Delete Tag", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                SqliteDataAccess.DeleteTagById(selectedId);

            selectedId = -1;
            clearDataView();

            LoadList();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadTransactionTypes();
            LoadList();
        }

        private void setTagDataView(TagModel tag)
        {
            nameTextBox.Text = tag.Name;
            transactionTypeComboBox.SelectedValue = tag.Id_Transaction_Type;
        }

        private void clearDataView()
        {
            nameTextBox.Clear();
            transactionTypeComboBox.SelectedIndex = 0;
        }
    }
}
