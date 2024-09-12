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
        public string MoneyText => $"{Symbol} ({Code})";
        public string FullName => $"{Name} ({Code})";
    }
}
