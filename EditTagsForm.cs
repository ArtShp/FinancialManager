using System.Data.SQLite;

namespace FinancialManager
{
    public partial class EditTagsForm : Form
    {
        private long selectedId = -1;
        private Size originalFormSize;
        private Size originalListViewSize;

        public EditTagsForm()
        {
            InitializeComponent();

            LoadAll();

            originalFormSize = new Size(Size.Width, Size.Height);
            originalListViewSize = new Size(listView.Width, listView.Height);
        }

        #region Loaders

        private void LoadAll()
        {
            try
            {
                LoadTransactionTypes();
                LoadList();
            }
            catch
            {
                MessageBox.Show("Error while loading data from DB. Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
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
            var data = SqliteDataAccess.LoadTags();

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

            listView.EndUpdate();
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        #endregion

        #region View Controls

        private void SetDataView(TagModel tag)
        {
            nameTextBox.Text = tag.Name;
            transactionTypeComboBox.SelectedValue = tag.Id_Transaction_Type;
        }

        private void ClearDataView()
        {
            nameTextBox.Clear();
            transactionTypeComboBox.SelectedIndex = 0;
        }

        #endregion

        #region Buttons Click Handlers

        private void editButton_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
                return;

            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag);
            TagModel tag = SqliteDataAccess.GetTagById(selectedId);
            SetDataView(tag);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
                return;

            if (nameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a name for the tag", "Edit tag", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TagModel tag = new TagModel
            {
                Id = selectedId,
                Name = nameTextBox.Text.Trim(),
                Id_Transaction_Type = Convert.ToInt64(transactionTypeComboBox.SelectedValue)
            };

            try
            {
                SqliteDataAccess.UpdateTag(tag);
            }
            catch (SQLiteException ex)
            {
                if (ex.Message.Contains("UNIQUE constraint failed"))
                {
                    MessageBox.Show("You can't have tags with the same Names", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("An error occurred while updating tag!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

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
                MessageBox.Show("Please cancel edit before adding a new tag", "Add tag", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a name for the tag", "Add tag", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TagModel tag = new TagModel
            {
                Name = nameTextBox.Text.Trim(),
                Id_Transaction_Type = Convert.ToInt64(transactionTypeComboBox.SelectedValue)
            };

            try
            {
                SqliteDataAccess.AddTag(tag);
            }
            catch (SQLiteException ex)
            {
                if (ex.Message.Contains("UNIQUE constraint failed"))
                {
                    MessageBox.Show("You can't have tags with the same Names", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("An error occurred while adding tag!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            ClearDataView();

            LoadList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
                return;

            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag);

            var result = MessageBox.Show("Are you sure you want to delete this tag?", "Delete Tag", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                SqliteDataAccess.DeleteTagById(selectedId);

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

        private void EditTagsForm_Resize(object sender, EventArgs e)
        {
            ResizeListView();
        }

        private void EditTagsForm_ResizeEnd(object sender, EventArgs e)
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
