namespace FinancialManager
{
    public partial class EditTagsForm : Form
    {
        private long selectedId = -1;

        public EditTagsForm()
        {
            InitializeComponent();

            LoadAll();
        }

        #region Loaders

        private void LoadAll()
        {
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
            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag);
            TagModel tag = SqliteDataAccess.GetTagById(selectedId);
            SetDataView(tag);
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

            TagModel tag = new TagModel
            {
                Name = nameTextBox.Text,
                Id_Transaction_Type = Convert.ToInt64(transactionTypeComboBox.SelectedValue)
            };

            SqliteDataAccess.AddTag(tag);

            ClearDataView();

            LoadList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
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
    }
}
