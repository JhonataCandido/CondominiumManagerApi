namespace CondominiumManagerApi.Core.Entities
{
    public class Expense
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public long IdCondominium { get; set; }
        public Condominium Condominium { get; set; }
    }
}