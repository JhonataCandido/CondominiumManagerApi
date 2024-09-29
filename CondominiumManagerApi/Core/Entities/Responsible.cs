namespace CondominiumManagerApi.Core.Entities
{
    public class Responsible
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public long IdCondominium { get; set; }
        public Condominium Condominium { get; set; }
    }
}