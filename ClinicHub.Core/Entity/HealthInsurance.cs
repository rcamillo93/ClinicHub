namespace ClinicHub.Core.Entity
{
    public class HealthInsurance : BaseEntity
    {
        public HealthInsurance(string name, string description, decimal discount, DateTime validity)
        {
            Name = name;
            Description = description;
            Discount = discount;
            Validity = validity;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Discount { get; private set; }
        public DateTime Validity { get; private set; }
    }
}