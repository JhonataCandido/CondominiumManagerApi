namespace CondominiumManagerApi.Core.Entities
{
    public class Event
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public long IdCondominium { get; set; }
        public Condominium Condominium { get; set; }
    }
}