using System.Data.SQLite;

namespace FinancialManager
{
    public partial class EditPlacesOfPurchasesForm : Form
    {
        private long selectedId = -1;
        private Size originalFormSize;
        private Size originalListViewSize;

        public EditPlacesOfPurchasesForm()
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
            var data = SqliteDataAccess.LoadPlacesOfPurchases();

            listView.BeginUpdate();
            listView.Items.Clear();

            foreach (var placeOfPurchase in data)
            {
                listView.Items.Add(
                    new ListViewItem(placeOfPurchase.ItemArray)
                    {
                        Tag = placeOfPurchase.Id
                    });
            }

            listView.EndUpdate();
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        #endregion

        #region View Controls

        private void SetDataView(PlaceOfPurchaseModel placeOfPurchase)
        {
            nameTextBox.Text = placeOfPurchase.Name;
        }

        private void ClearDataView()
        {
            nameTextBox.Clear();
        }

        #endregion

        #region Buttons Click Handlers

        private void editButton_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
                return;

            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag);
            PlaceOfPurchaseModel placeOfPurchase = SqliteDataAccess.GetPlaceOfPurchaseById(selectedId);
            SetDataView(placeOfPurchase);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
                return;

            PlaceOfPurchaseModel placeOfPurchase = new PlaceOfPurchaseModel
            {
                Id = selectedId,
                Name = nameTextBox.Text
            };

            try
            {
                SqliteDataAccess.UpdatePlaceOfPurchase(placeOfPurchase);
            }
            catch (SQLiteException ex)
            {
                if (ex.Message.Contains("UNIQUE constraint failed"))
                {
                    MessageBox.Show("You can't have places of purchase with the same Names", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("An error occurred while updating place of purchase!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please cancel edit before adding a new place of purchase", "Add place of purchase", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PlaceOfPurchaseModel placeOfPurchase = new PlaceOfPurchaseModel
            {
                Name = nameTextBox.Text
            };

            try
            {
                SqliteDataAccess.AddPlaceOfPurchase(placeOfPurchase);
            }
            catch (SQLiteException ex)
            {
                if (ex.Message.Contains("UNIQUE constraint failed"))
                {
                    MessageBox.Show("You can't have places of purchase with the same Names", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("An error occurred while adding place of purchase!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            var result = MessageBox.Show("Are you sure you want to delete this place of purchase?", "Delete place of purchase", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    SqliteDataAccess.DeletePlaceOfPurchaseById(selectedId);
                }
                catch (SQLiteException ex)
                {
                    if (ex.Message.Contains("FOREIGN KEY constraint failed"))
                    {
                        MessageBox.Show("You can't delete place of purchase that is used!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("An error occurred while deleting place of purchase!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void EditPlacesOfPurchasesForm_Resize(object sender, EventArgs e)
        {
            ResizeListView();
        }

        private void EditPlacesOfPurchasesForm_ResizeEnd(object sender, EventArgs e)
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
