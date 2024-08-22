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
        public long Sum_By_Account { get; set; }
        public long Id_Currency_Of_Transaction { get; set; }
        public long Id_Cash_Facility { get; set; }
        public long Id_Place_Of_Purchase { get; set; }
        public string Description { get; set; }

        public static string ConvertSumToString(int number, int rate)
        {
            long multiplier = Convert.ToInt64(Math.Pow(10, rate));

            long integer = number / multiplier;
            long fraction = number % multiplier;

            string strInteger = integer.ToString();
            string strFraction = fraction.ToString();
            if (strFraction.Length < rate)
            {
                strFraction = new string('0', rate - strFraction.Length) + strFraction;
            }

            return strInteger + "." + strFraction;
        }

        public static long ConvertStringToSum(string number, int rate)
        {
            long multiplier = Convert.ToInt64(Math.Pow(10, rate));

            string[] parts = number.Split('.');

            if (parts.Length == 1)
            {
                return Convert.ToInt64(parts[0]) * multiplier;
            }

            return Convert.ToInt64(parts[0]) * multiplier + Convert.ToInt64(parts[1]);
        }
    }
}
