namespace ClinicHub.Core.Entity
{
    public class Service : BaseEntity
    {
        public Service(string name, string description, int duration)
        {
            Name = name;
            Description = description;
            Duration = duration;
            CustomerServices = new List<CustomerService>();
            Pricings = new List<Pricing>();
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Duration { get; private set; }
        public List<CustomerService> CustomerServices { get; private set; }
        public List<Pricing> Pricings { get; private set; }
    }
}
