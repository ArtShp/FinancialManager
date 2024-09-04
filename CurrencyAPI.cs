using currencyapi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FinancialManager
{
    internal static class CurrencyAPI
    {
        public static Decimal GetCurrencyRate(CurrencyModel fromCurrency, CurrencyModel toCurrency)
        {
            try
            {
                var fx = new Currencyapi(Properties.Settings.Default.CurrencyApiKey);
                var request = fx.Latest(fromCurrency.Code, toCurrency.Code);

                CurrencyData currencyData = JsonSerializer.Deserialize<CurrencyData>(request);

                return currencyData.Data[toCurrency.Code].Value;
            }
            catch
            {
                throw new Exception("Failed to get currency rate");
            }
        }

        public static bool testConnection(string key)
        {
            try
            {
                var fx = new Currencyapi(key);
                var request = fx.Latest("USD", "EUR");
                CurrencyData currencyData = JsonSerializer.Deserialize<CurrencyData>(request);

                var testData = currencyData.Data["EUR"].Value;

                return true;
            }
            catch
            {
                return false;
            }
        }

        private class CurrencyData
        {
            [JsonPropertyName("meta")]
            public Meta Meta { get; set; }

            [JsonPropertyName("data")]
            public Dictionary<string, CurrencyInfo> Data { get; set; }
        }

        private class Meta
        {
            [JsonPropertyName("last_updated_at")]
            public DateTime LastUpdatedAt { get; set; }
        }

        private class CurrencyInfo
        {
            [JsonPropertyName("code")]
            public string Code { get; set; }

            [JsonPropertyName("value")]
            public Decimal Value { get; set; }
        }
    }
}
