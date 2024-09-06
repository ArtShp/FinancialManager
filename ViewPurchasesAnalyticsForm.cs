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
    public partial class ViewPurchasesAnalyticsForm : Form
    {
        private bool isFromDateSet = false;
        private bool isToDateSet = false;

        public ViewPurchasesAnalyticsForm()
        {
            InitializeComponent();

            LoadAll();
            ClearFromDate();
            ClearToDate();
        }

        private void LoadAll()
        {
            LoadTransactionTypes();
            LoadPlacesOfPurchases();
        }

        private void LoadTransactionTypes()
        {
            var data = SqliteDataAccess.LoadTransactionTypes();

            transactionTypeComboBox.DataSource = data;
            transactionTypeComboBox.DisplayMember = "Name";
            transactionTypeComboBox.ValueMember = "Id";
        }

        private void LoadPlacesOfPurchases()
        {
            var data = SqliteDataAccess.LoadPlacesOfPurchases();

            placeComboBox.DataSource = data;
            placeComboBox.DisplayMember = "Name";
            placeComboBox.ValueMember = "Id";
        }

        private void ClearFromDate()
        {
            fromDateTimePicker.CustomFormat = "---NONE---";
            isFromDateSet = false;
        }

        private void ClearToDate()
        {
            toDateTimePicker.CustomFormat = "---NONE---";
            isToDateSet = false;
        }

        private void fromDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            fromDateTimePicker.CustomFormat = "dd.MM.yyyy";
            isFromDateSet = true;
        }

        private void toDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            toDateTimePicker.CustomFormat = "dd.MM.yyyy";
            isToDateSet = true;
        }
    }
}
