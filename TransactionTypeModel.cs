namespace FinancialManager
{
    internal class TransactionTypeModel
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public string[] ItemArray => new[] { Name };
    }
}
