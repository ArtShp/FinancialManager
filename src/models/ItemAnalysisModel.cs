namespace FinancialManager
{
    internal class ItemAnalysisModel
    {
        public long Id { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public MoneyModel Sum { get; set; }
        public long CurrencyId { get; set; }
        public string CurrencyText { get; set; }
        public MoneyModel SumByMainCurrency { get; set; }
        public string Place { get; set; }
        public long TransactionTypeId { get; set; }
        public string Tags { get; set; }
    }
}
