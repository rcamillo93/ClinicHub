namespace ClinicHub.Core.Entity
{
    public class ConsultationType : BaseEntity
    {
        public ConsultationType(string title, string description, decimal value)
        {
            Title = title;
            Description = description;
            Value = value;
            CustomerServices = new List<CustomerService>();
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal Value { get; private set; }
        public List<CustomerService> CustomerServices { get; private set; }
    }
}
