namespace CondominiumManagerApi.Core.Entities
{
    public class Resident
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}