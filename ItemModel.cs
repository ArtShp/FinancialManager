namespace FinancialManager
{
    internal class ItemModel
    {
        public long Id { get; set; }
        public long Id_Transaction { get; set; }
        public MoneyModel Sum { get; set; }
        public MoneyModel Sum_By_Main_Currency { get; set; }
        public long Id_Category { get; set; }
        public string Description { get; set; }
    }
}
