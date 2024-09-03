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
            var fx = new Currencyapi(Properties.Resources.CurrencyApiKey);
            var request = fx.Latest(fromCurrency.Code, toCurrency.Code);

            CurrencyData currencyData = JsonSerializer.Deserialize<CurrencyData>(request);

            return currencyData.Data[toCurrency.Code].Value;
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
