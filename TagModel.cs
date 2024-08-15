using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager
{
    internal class TagModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long IdTransactionType { get; set; }

        public string[] ItemArray => new[] { Name, IdTransactionType.ToString() };
    }
}
