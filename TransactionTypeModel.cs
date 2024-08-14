using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager
{
    internal class TransactionTypeModel
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public string[] ItemArray => new[] { Name };
    }
}
