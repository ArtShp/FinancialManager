using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager
{
    internal static class CurrencyConverter
    {
        public static MoneyModel ConvertMoney(MoneyModel money, CurrencyModel fromCurrency, CurrencyModel toCurrency)
        {
            if (fromCurrency.Code == toCurrency.Code)
            {
                return money;
            }

            try
            {
                Decimal sum = Convert.ToDecimal(money.GetString()) * GetCurrencyRate(fromCurrency, toCurrency);

                return new MoneyModel(sum.ToString(), toCurrency.Units_Rate);
            }
            catch(Exception e)
            {
                throw new Exception("Failed to convert money", e);
            }
        }

        private static Decimal GetCurrencyRate(CurrencyModel fromCurrency, CurrencyModel toCurrency)
        {
            try
            {
                return CurrencyAPI.GetCurrencyRate(fromCurrency, toCurrency);
            }
            catch(Exception e)
            {
                throw new Exception("Failed to get currency rate", e);
            }
        }
    }
}
