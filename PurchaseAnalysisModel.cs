using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager
{
    internal class PurchaseAnalysisModel
    {
        public long Id { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public MoneyModel Sum { get; set; }
        public long CurrencyId { get; set; }
        public string CurrencyText { get; set; }
        public MoneyModel SumByMainCurrency { get; set; }
        public string Place { get; set; }
        public string TransactionType { get; set; }
        public string Tags { get; set; }
    }
}
