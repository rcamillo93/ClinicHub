using ClinicHub.Core.Entity;

namespace ClinicHub.Application.ViewModel
{
    public class HealthInsuranceViewModel
    {
        public HealthInsuranceViewModel(int id, string name, string description, DateTime validity)
        {
            Id = id;
            Name = name;
            Description = description;
            Validity = validity;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Validity { get; set; }
        public List<Pricing> Pricings { get; set; } = new();
    }
}