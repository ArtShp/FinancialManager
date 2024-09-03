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

            money.Rate = fromCurrency.Units_Rate;

            Decimal sum = Convert.ToDecimal(money.GetString()) * GetCurrencyRate(fromCurrency, toCurrency);

            return new MoneyModel(sum.ToString(), toCurrency.Units_Rate);
        }

        private static Decimal GetCurrencyRate(CurrencyModel fromCurrency, CurrencyModel toCurrency)
        {
            return CurrencyAPI.GetCurrencyRate(fromCurrency, toCurrency);
        }
    }
}
