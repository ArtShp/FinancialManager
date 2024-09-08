using System.Data.SQLite;

namespace FinancialManager
{
    public partial class EditCashFacilitiesForm : Form
    {
        private long selectedId = -1;
        private Size originalFormSize;
        private Size originalListViewSize;

        public EditCashFacilitiesForm()
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
                LoadCurrencies();
                LoadList();
            }
            catch
            {
                MessageBox.Show("Error while loading data from DB. Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void LoadCurrencies()
        {
            var currencies = SqliteDataAccess.LoadCurrencies();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = currencies;

            currencyComboBox.DataSource = bindingSource.DataSource;
            currencyComboBox.DisplayMember = "Name";
            currencyComboBox.ValueMember = "Id";
        }

        private void LoadList()
        {
            try
            {
                var data = SqliteDataAccess.LoadCashFacilities();

                listView.BeginUpdate();
                listView.Items.Clear();

                foreach (var cashFacility in data)
                {
                    var currency = SqliteDataAccess.GetCurrencyById(cashFacility.Id_Currency);
                    listView.Items.Add(
                        new ListViewItem(new[] { cashFacility.Name, currency.Name })
                        {
                            Tag = cashFacility.Id
                        });
                }

                listView.EndUpdate();
                listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch
            {
                MessageBox.Show("Error while loading data from DB. Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        #endregion

        #region View Controls

        private void SetDataView(CashFacilityModel cashFacility)
        {
            nameTextBox.Text = cashFacility.Name;
            currencyComboBox.SelectedValue = cashFacility.Id_Currency;
        }

        private void ClearDataView()
        {
            nameTextBox.Clear();
            currencyComboBox.SelectedIndex = 0;
        }

        #endregion

        #region Buttons Click Handlers

        private void editButton_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag);
            var cashFacility = SqliteDataAccess.GetCashFacilityById(selectedId);
            SetDataView(cashFacility);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
                return;

            CashFacilityModel cashFacility = new CashFacilityModel
            {
                Id = selectedId,
                Name = nameTextBox.Text,
                Id_Currency = Convert.ToInt64(currencyComboBox.SelectedValue)
            };

            try
            {
                SqliteDataAccess.UpdateCashFacility(cashFacility);
            }
            catch (SQLiteException ex)
            {
                if (ex.Message.Contains("UNIQUE constraint failed"))
                {
                    MessageBox.Show("You can't have cash facilities with the same Names", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("An error occurred while updating cash facility!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please cancel edit before adding a new cash facility", "Add cash facility", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CashFacilityModel cashFacility = new CashFacilityModel
            {
                Name = nameTextBox.Text,
                Id_Currency = Convert.ToInt64(currencyComboBox.SelectedValue)
            };

            try
            {
                SqliteDataAccess.AddCashFacility(cashFacility);
            }
            catch (SQLiteException ex)
            {
                if (ex.Message.Contains("UNIQUE constraint failed"))
                {
                    MessageBox.Show("You can't have cash facilities with the same Names", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("An error occurred while adding cash facility!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            ClearDataView();

            LoadList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag);

            var result = MessageBox.Show("Are you sure you want to delete this cash facility?", "Delete Cash Facility", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    SqliteDataAccess.DeleteCashFacilityById(selectedId);
                }
                catch (SQLiteException ex)
                {
                    if (ex.Message.Contains("FOREIGN KEY constraint failed"))
                    {
                        MessageBox.Show("You can't delete cash facility that is used!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while deleting cash facility!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void EditCashFacilitiesForm_Resize(object sender, EventArgs e)
        {
            ResizeListView();
        }

        private void EditCashFacilitiesForm_ResizeEnd(object sender, EventArgs e)
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
