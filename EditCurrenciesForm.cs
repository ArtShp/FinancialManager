using System.Data.SQLite;

namespace FinancialManager
{
    public partial class EditCurrenciesForm : Form
    {
        private long selectedId = -1;
        private Size originalFormSize;
        private Size originalListViewSize;

        public EditCurrenciesForm()
        {
            InitializeComponent();

            LoadAll();

            originalFormSize = new Size(Size.Width, Size.Height);
            originalListViewSize = new Size(listView.Width, listView.Height);
        }

        #region Loaders

        private void LoadAll()
        {
            LoadList();
        }

        private void LoadList()
        {
            var data = SqliteDataAccess.LoadCurrencies();

            listView.BeginUpdate();
            listView.Items.Clear();

            foreach (var currency in data)
            {
                if (currency.Id == SqliteDataAccess.MainCurrencyId)
                {
                    listView.Items.Add(
                    new ListViewItem(currency.ItemArray)
                    {
                        Tag = currency.Id,
                        ForeColor = Color.Blue,
                        Font = new Font(listView.Font, FontStyle.Bold)
                    });
                }
                else
                {
                    listView.Items.Add(
                    new ListViewItem(currency.ItemArray)
                    {
                        Tag = currency.Id
                    });
                }
            }

            listView.EndUpdate();
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        #endregion

        #region View Controls

        private void SetDataView(CurrencyModel currency)
        {
            nameTextBox.Text = currency.Name;
            codeTextBox.Text = currency.Code;
            symbolTextBox.Text = currency.Symbol;
            unitsRateNumericUpDown.Value = currency.Units_Rate;
        }

        private void ClearDataView()
        {
            nameTextBox.Clear();
            codeTextBox.Clear();
            symbolTextBox.Clear();
            unitsRateNumericUpDown.Value = 0;
        }

        #endregion

        #region Buttons Click Handlers

        private void editButton_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag);

            if (selectedId == SqliteDataAccess.MainCurrencyId)
            {
                MessageBox.Show("You can't edit main currency!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                selectedId = -1;

                return;
            }

            CurrencyModel currency = SqliteDataAccess.GetCurrencyById(selectedId);
            SetDataView(currency);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
                return;

            CurrencyModel currency = new CurrencyModel
            {
                Id = selectedId,
                Name = nameTextBox.Text,
                Code = codeTextBox.Text,
                Symbol = symbolTextBox.Text,
                Units_Rate = Convert.ToInt32(unitsRateNumericUpDown.Value)
            };

            try
            {
                SqliteDataAccess.UpdateCurrency(currency);
            }
            catch (SQLiteException ex)
            {
                if (ex.Message.Contains("UNIQUE constraint failed"))
                {
                    MessageBox.Show("You can't have currecnies with the same Names or Codes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("An error occurred while updating currency!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please cancel edit before adding a new currency", "Add currency", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (SqliteDataAccess.GetCurrenciesCount() == 0)
            {
                var result = MessageBox.Show("You are adding the main currency. In future it can't be changed!\nDo you want to continue?", "Add main currency", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes)
                    return;
            }

            CurrencyModel currency = new CurrencyModel
            {
                Name = nameTextBox.Text,
                Code = codeTextBox.Text,
                Symbol = symbolTextBox.Text,
                Units_Rate = Convert.ToInt32(unitsRateNumericUpDown.Value)
            };

            try
            {
                SqliteDataAccess.AddCurrency(currency);
            }
            catch (SQLiteException ex)
            {
                if (ex.Message.Contains("UNIQUE constraint failed"))
                {
                    MessageBox.Show("You can't have currecnies with the same Names or Codes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("An error occurred while adding currency!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            ClearDataView();

            LoadList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag);

            if (selectedId == SqliteDataAccess.MainCurrencyId)
            {
                MessageBox.Show("You can't delete main currency!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                selectedId = -1;

                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this currency?", "Delete currency", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    SqliteDataAccess.DeleteCurrencyById(selectedId);
                }
                catch (SQLiteException ex)
                {
                    if (ex.Message.Contains("FOREIGN KEY constraint failed"))
                    {
                        MessageBox.Show("You can't delete currency that is used!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while deleting currency!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

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

        private void EditCurrenciesForm_Resize(object sender, EventArgs e)
        {
            ResizeListView();
        }

        private void EditCurrenciesForm_ResizeEnd(object sender, EventArgs e)
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
