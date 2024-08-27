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
        public long Sum_By_Transaction { get; set; }
        public long Id_Category { get; set; }
        public string Description { get; set; }
    }
}
