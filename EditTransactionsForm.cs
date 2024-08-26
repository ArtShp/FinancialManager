using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace FinancialManager
{
    public partial class EditTransactionsForm : Form
    {
        private List<TransactionModel> data = new List<TransactionModel>();
        private long selectedId = -1;

        public EditTransactionsForm()
        {
            InitializeComponent();

            LoadAll();
        }

        private void LoadAll()
        {
            LoadTransactionTypes();
            LoadCurrencies();
            LoadCashFacilities();
            LoadPlacesOfPurchases();
            LoadList();
        }

        private void LoadTransactionTypes()
        {
            var transactionTypes = SqliteDataAccess.LoadTransactionTypes();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = transactionTypes;

            transactionComboBox.DataSource = bindingSource.DataSource;
            transactionComboBox.DisplayMember = "Name";
            transactionComboBox.ValueMember = "Id";
        }

        private void LoadCurrencies()
        {
            var currencies = SqliteDataAccess.LoadCurrencies();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = currencies;

            currencyComboBox.DataSource = bindingSource.DataSource;
            currencyComboBox.DisplayMember = "Code";
            currencyComboBox.ValueMember = "Id";
        }

        private void LoadCashFacilities()
        {
            var cashFacilities = SqliteDataAccess.LoadCashFacilities();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = cashFacilities;

            cashComboBox.DataSource = bindingSource.DataSource;
            cashComboBox.DisplayMember = "Name";
            cashComboBox.ValueMember = "Id";
        }

        private void LoadPlacesOfPurchases()
        {
            var placesOfPurchases = new List<PlaceOfPurchaseModel> {
                new PlaceOfPurchaseModel { Id = 0, Name = "" }
            };
            placesOfPurchases.AddRange(SqliteDataAccess.LoadPlacesOfPurchases());

            var bindingSource = new BindingSource();
            bindingSource.DataSource = placesOfPurchases;

            placeComboBox.DataSource = bindingSource.DataSource;
            placeComboBox.DisplayMember = "Name";
            placeComboBox.ValueMember = "Id";
        }

        private void LoadList()
        {
            data = SqliteDataAccess.LoadTransactions();

            UpdateList();
        }

        private void UpdateList()
        {
            listView.BeginUpdate();
            listView.Items.Clear();

            foreach (var transaction in data)
            {
                var transactionType = SqliteDataAccess.GetTransactionTypeById(transaction.Id_Transaction_Type);
                var currency = SqliteDataAccess.GetCurrencyById(transaction.Id_Currency_Of_Transaction);
                var cashFacility = SqliteDataAccess.GetCashFacilityById(transaction.Id_Cash_Facility);

                transaction.Sum_By_Account.Rate = getUnitsRate(cashFacility);

                string place = "";
                if (transaction.Id_Place_Of_Purchase != 0)
                {
                    place = SqliteDataAccess.GetPlaceOfPurchaseById(transaction.Id_Place_Of_Purchase).Name;
                }

                listView.Items.Add(
                    new ListViewItem(new[] { transactionType.Name, transaction.Date.ToString("dd.MM.yyyy"), transaction.Sum_By_Account.GetString(), currency.Code, cashFacility.Name, place, transaction.Description })
                    {
                        Tag = transaction.Id
                    });
            }
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView.EndUpdate();
        }

        private int getUnitsRate(long idCashFacility)
        {
            var cashFacility = SqliteDataAccess.GetCashFacilityById(idCashFacility);
            return getUnitsRate(cashFacility);
        }

        private int getUnitsRate(CashFacilityModel cashFacility)
        {
            var cashFacilityCurrency = SqliteDataAccess.GetCurrencyById(cashFacility.Id_Currency);
            return cashFacilityCurrency.Units_Rate;
        }

        private void clearDataView()
        {
            transactionComboBox.SelectedIndex = 0;
            dateTimePicker.Value = DateTime.Now;
            sumTextBox.Text = "0";
            currencyComboBox.SelectedIndex = 0;
            cashComboBox.SelectedIndex = 0;
            placeComboBox.SelectedIndex = 0;
            descriptionRichTextBox.Clear();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadAll();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var idCashFacility = Convert.ToInt64(cashComboBox.SelectedValue);

            TransactionModel transaction = new TransactionModel
            {
                Id_Transaction_Type = Convert.ToInt64(transactionComboBox.SelectedValue),
                Date = dateTimePicker.Value,
                Sum_By_Account = new MoneyModel(sumTextBox.Text, getUnitsRate(idCashFacility)),
                Id_Currency_Of_Transaction = Convert.ToInt64(currencyComboBox.SelectedValue),
                Id_Cash_Facility = idCashFacility,
                Id_Place_Of_Purchase = Convert.ToInt64(placeComboBox.SelectedValue),
                Description = descriptionRichTextBox.Text
            };

            SqliteDataAccess.AddTransaction(transaction);

            clearDataView();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            selectedId = Convert.ToInt64(listView.SelectedItems[0].Tag);

            var result = MessageBox.Show("Are you sure you want to delete this transaction?", "Delete Transaction", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                SqliteDataAccess.DeleteTransactionById(selectedId);

            selectedId = -1;
            clearDataView();
        }
    }
}
