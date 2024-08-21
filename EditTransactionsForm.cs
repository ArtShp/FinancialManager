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

            LoadList();
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
    }
}
