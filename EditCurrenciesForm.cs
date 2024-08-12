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
    public partial class EditCurrenciesForm : Form
    {
        private List<CurrencyModel> data = new List<CurrencyModel>();

        public EditCurrenciesForm()
        {
            InitializeComponent();

            LoadCurrenciesList();
        }

        private void LoadCurrenciesList()
        {
            data = SqliteDataAccess.LoadCurrencies();

            UpdateCurrenciesList();
        }

        private void UpdateCurrenciesList()
        {
            currenciesListBox.DataSource = data;
            currenciesListBox.DisplayMember = "Name";
        }
    }
}
