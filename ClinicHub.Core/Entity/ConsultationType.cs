namespace ClinicHub.Core.Entity
{
    public class ConsultationType : BaseEntity
    {
        public ConsultationType(string title, string description)
        {
            Title = title;
            Description = description;
            CustomerServices = new List<CustomerService>();
            Pricings = new List<Pricing>();
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public List<CustomerService> CustomerServices { get; private set; }
        public List<Pricing> Pricings { get; private set; }
    }
}
