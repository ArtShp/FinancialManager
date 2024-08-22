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
    public partial class EditTransactionsForm : Form
    {
        private List<TransactionModel> data = new List<TransactionModel>();
        private long selectedId = -1;

        public EditTransactionsForm()
        {
            InitializeComponent();

            LoadAll();
        }

        private string FromDbToView(long number, int rate = 2)
        {
            long multiplier = Convert.ToInt64(Math.Pow(10, rate));

            long integer = number / multiplier;
            long fraction = number % multiplier;

            string strInteger = integer.ToString();
            string strFraction = fraction.ToString();
            if (strFraction.Length < rate)
            {
                strFraction = new string('0', rate - strFraction.Length) + strFraction;
            }

            return strInteger + "." + strFraction;
        }

        private long FromViewToDb(string number, int rate = 2)
        {
            long multiplier = Convert.ToInt64(Math.Pow(10, rate));

            string[] parts = number.Split('.');

            if (parts.Length == 1)
            {
                return Convert.ToInt64(parts[0]) * multiplier;
            }

            return Convert.ToInt64(parts[0]) * multiplier + Convert.ToInt64(parts[1]);
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
            var placesOfPurchases = SqliteDataAccess.LoadPlacesOfPurchases();
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

                string place = "";
                if (transaction.Id_Place_Of_Purchase != 0)
                {
                    place = SqliteDataAccess.GetPlaceOfPurchaseById(transaction.Id_Place_Of_Purchase).Name;
                }
                var placeOfPurchase = SqliteDataAccess.GetPlaceOfPurchaseById(transaction.Id_Place_Of_Purchase);

                listView.Items.Add(
                    new ListViewItem(new[] { transactionType.Name, transaction.Date.ToString("dd.MM.yyyy"), transaction.Sum_By_Account.ToString(), currency.Code, cashFacility.Name, place, transaction.Description })
                    {
                        Tag = transaction.Id
                    });
            }
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView.EndUpdate();
        }

        private void clearDataView()
        {
            transactionComboBox.SelectedIndex = 0;
            dateTimePicker.Value = DateTime.Now;
            sumTextBox.Clear();
            currencyComboBox.SelectedIndex = 0;
            cashComboBox.SelectedIndex = 0;
            placeComboBox.SelectedIndex = 0;
            descriptionRichTextBox.Clear();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            LoadAll();
        }
    }
}
