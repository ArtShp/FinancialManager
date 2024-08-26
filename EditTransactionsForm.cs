﻿using System;
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
                    new ListViewItem(new[] { transactionType.Name, transaction.Date.ToString("dd.MM.yyyy"), TransactionModel.ConvertSumToString(transaction.Sum_By_Account, 2), currency.Code, cashFacility.Name, place, transaction.Description })
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
            sumTextBox.Text = "0.0";
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
            TransactionModel transaction = new TransactionModel
            {
                Id_Transaction_Type = Convert.ToInt64(transactionComboBox.SelectedValue),
                Date = dateTimePicker.Value,
                Sum_By_Account = TransactionModel.ConvertStringToSum(sumTextBox.Text, 2),
                Id_Currency_Of_Transaction = Convert.ToInt64(currencyComboBox.SelectedValue),
                Id_Cash_Facility = Convert.ToInt64(cashComboBox.SelectedValue),
                Id_Place_Of_Purchase = Convert.ToInt64(placeComboBox.SelectedValue),
                Description = descriptionRichTextBox.Text
            };

            SqliteDataAccess.AddTransaction(transaction);

            clearDataView();
        }
    }
}
