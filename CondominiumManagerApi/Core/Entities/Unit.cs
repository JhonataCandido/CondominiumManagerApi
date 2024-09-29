namespace CondominiumManagerApi.Core.Entities
{
    public class Unit
    {
        public long Id { get; set; }
        public string UnitNumber { get; set; }
        public string Floor { get; set; }
        public long IdResident { get; set; }
        public string ContractNumber { get; set; }
        public Resident Resident { get; set; }
    }
}