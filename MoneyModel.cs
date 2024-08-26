using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager
{
    internal class MoneyModel
    {
        public long Money { get; set; }
        public int Rate { get; set; }


        public MoneyModel(string money, int rate)
        {
            Rate = rate;

            SetValue(money);
        }

        public MoneyModel(long money, int rate = 0)
        {
            Rate = rate;

            SetValue(money);
        }

        public string GetString()
        {
            long multiplier = Convert.ToInt64(Math.Pow(10, Rate));

            long integer = Money / multiplier;
            long fraction = Money % multiplier;

            string strInteger = integer.ToString();
            string strFraction = fraction.ToString();
            if (strFraction.Length < Rate)
            {
                strFraction = new string('0', Rate - strFraction.Length) + strFraction;
            }

            return strInteger + "." + strFraction;
        }

        public long GetLong()
        {
            return Money;
        }

        public void SetValue(string number)
        {
            long multiplier = Convert.ToInt64(Math.Pow(10, Rate));

            string[] parts = number.Split('.');

            if (parts.Length == 1)
            {
                Money = Convert.ToInt64(parts[0]) * multiplier;
            }
            else
            {
                Money = Convert.ToInt64(parts[0]) * multiplier + Convert.ToInt64(parts[1]);
            }
        }

        public void SetValue(long number)
        {
            Money = number;
        }
    }
}
