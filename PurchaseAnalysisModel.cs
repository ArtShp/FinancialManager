using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager
{
    internal class PurchaseAnalysisModel
    {
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public MoneyModel Sum { get; set; }
        public CurrencyModel Currency { get; set; }
        public MoneyModel Sum_By_Main_Currency { get; set; }
        public string Place { get; set; }
        public string TransactionType { get; set; }
        public string Tags { get; set; }
    }
}
