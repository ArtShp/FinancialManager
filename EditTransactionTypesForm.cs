namespace FinancialManager
{
    public partial class EditTransactionTypesForm : Form
    {
        private long selectedId = -1;

        public EditTransactionTypesForm()
        {
            InitializeComponent();

            addButton.Enabled = false;
            deleteButton.Enabled = false;

            LoadAll();
        }

        #region Loaders

        private void LoadAll()
        {
            LoadList();
        }

        private void LoadList()
        {
            var data = SqliteDataAccess.LoadTransactionTypes();

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

            listView.EndUpdate();
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        #endregion

        #region View Controls

        private void SetDataView(TransactionTypeModel transactionType)
        {
            nameTextBox.Text = transactionType.Name;
        }

        private void ClearDataView()
        {
            nameTextBox.Clear();
        }

        #endregion

        #region Buttons Click Handlers

        private void editButton_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag);
            TransactionTypeModel transactionType = SqliteDataAccess.GetTransactionTypeById(selectedId);
            SetDataView(transactionType);
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
                MessageBox.Show("Please cancel edit before adding a new transaction type", "Add transaction type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TransactionTypeModel transactionType = new TransactionTypeModel
            {
                Name = nameTextBox.Text
            };

            SqliteDataAccess.AddTransactionType(transactionType);

            ClearDataView();

            LoadList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag);

            var result = MessageBox.Show("Are you sure you want to delete this transaction type?", "Delete transaction type", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                SqliteDataAccess.DeleteTransactionTypeById(selectedId);

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
