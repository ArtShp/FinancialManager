﻿using System;
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
    public partial class EditPurchasesForm : Form
    {
        private List<PurchaseModel> data = new List<PurchaseModel>();
        private long selectedId = -1;
        private long transactionId;
        private int unitsRate;

        public EditPurchasesForm(long transactionId)
        {
            this.transactionId = transactionId;

            var transaction = SqliteDataAccess.GetTransactionById(this.transactionId);
            var cashFacility = SqliteDataAccess.GetCashFacilityById(transaction.Id_Cash_Facility);

            unitsRate = SqliteDataAccess.GetUnitsRate(cashFacility);

            InitializeComponent();

            LoadList();
        }

        private void LoadList()
        {
            data = SqliteDataAccess.LoadPurchases(transactionId);

            UpdateList();
        }

        private void UpdateList()
        {
            listView.BeginUpdate();
            listView.Items.Clear();

            foreach (var purchase in data)
            {
                var category = SqliteDataAccess.GetCategoryById(purchase.Id_Category);
                purchase.Sum_By_Transaction.Rate = unitsRate;

                listView.Items.Add(
                    new ListViewItem(new[] { category.Name, purchase.Sum_By_Transaction.GetString(), purchase.Description })
                    {
                        Tag = purchase.Id
                    });
            }

            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView.EndUpdate();
        }
    }
}
