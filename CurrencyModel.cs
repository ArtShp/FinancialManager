using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager
{
    internal class CurrencyModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
        public int Units_Rate { get; set; }

        public string[] ItemArray => new[] { Name, Code, Symbol, Units_Rate.ToString() };

        public string GetMoneyText()
        {
            return $"{Symbol} ({Code})";
        }

        public string GetFullName()
        {
            return $"{Name} ({Code})";
        }
    }
}
