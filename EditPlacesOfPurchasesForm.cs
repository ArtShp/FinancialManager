﻿namespace FinancialManager
{
    public partial class EditPlacesOfPurchasesForm : Form
    {
        private long selectedId = -1;

        public EditPlacesOfPurchasesForm()
        {
            InitializeComponent();

            LoadAll();
        }

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

        private void editButton_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag);
            PlaceOfPurchaseModel placeOfPurchase = SqliteDataAccess.GetPlaceOfPurchaseById(selectedId);
            setPlaceOfPurchaseDataView(placeOfPurchase);
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

            SqliteDataAccess.UpdatePlaceOfPurchase(placeOfPurchase);

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
            if (selectedId != -1)
            {
                MessageBox.Show("Please cancel edit before adding a new place of purchase", "Add place of purchase", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PlaceOfPurchaseModel placeOfPurchase = new PlaceOfPurchaseModel
            {
                Name = nameTextBox.Text
            };

            SqliteDataAccess.AddPlaceOfPurchase(placeOfPurchase);

            clearDataView();

            LoadList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag);

            var result = MessageBox.Show("Are you sure you want to delete this place of purchase?", "Delete place of purchase", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                SqliteDataAccess.DeletePlaceOfPurchaseById(selectedId);

            selectedId = -1;
            clearDataView();

            LoadList();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadAll();
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
