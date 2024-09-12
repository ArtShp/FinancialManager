namespace FinancialManager
{
    internal class PlaceOfPurchaseModel
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public string[] ItemArray => new[] { Name };
    }
}
