namespace ClinicHub.Core.Entity
{
    public class HealthInsurance : BaseEntity
    {
        public HealthInsurance(string name, string description, DateTime validity)
        {
            Name = name;
            Description = description;      
            Validity = validity;
            Pricings = new List<Pricing>();
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public DateTime Validity { get; private set; }
        public List<Pricing> Pricings { get; private set; }
    }
}