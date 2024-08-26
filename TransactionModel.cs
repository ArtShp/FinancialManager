using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FinancialManager
{
    internal class TransactionModel
    {
        public long Id { get; set; }
        public long Id_Transaction_Type { get; set; }
        public DateTime Date { get; set; }
        public MoneyModel Sum_By_Account { get; set; }
        public long Id_Currency_Of_Transaction { get; set; }
        public long Id_Cash_Facility { get; set; }
        public long Id_Place_Of_Purchase { get; set; }
        public string Description { get; set; }
    }
}
