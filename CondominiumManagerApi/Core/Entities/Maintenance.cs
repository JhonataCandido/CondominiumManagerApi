namespace CondominiumManagerApi.Core.Entities
{
    public class Maintenance
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public long IdCondominium { get; set; }
        public Condominium Condominium { get; set; }
    }
}