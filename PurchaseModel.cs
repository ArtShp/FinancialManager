using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager
{
    internal class PurchaseModel
    {
        public long Id { get; set; }
        public long Id_Transaction { get; set; }
        public MoneyModel Sum { get; set; }
        public MoneyModel Sum_By_Main_Currency { get; set; }
        public long Id_Category { get; set; }
        public string Description { get; set; }
    }
}
