using currencyapi;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FinancialManager
{
    internal static class CurrencyAPI
    {
        public static Decimal GetCurrencyRate(CurrencyModel fromCurrency, CurrencyModel toCurrency, DateTime date)
        {
            try
            {
                var fx = new Currencyapi(Properties.Settings.Default.CurrencyApiKey);

                if (date == DateTime.Today)
                {
                    // Need this substraction because the API does not provide the rate for the current day, only for the previous days
                    date = date.AddDays(-1);
                }
                var request = fx.Historical(date.ToString("yyyy-MM-dd"), fromCurrency.Code, toCurrency.Code);

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
