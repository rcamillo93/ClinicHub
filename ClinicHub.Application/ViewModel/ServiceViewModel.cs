using ClinicHub.Core.Entity;

namespace ClinicHub.Application.ViewModel
{
    public class ServiceViewModel 
    {
        public ServiceViewModel(int id, string name, string description, int duration)
        {
            Id = id;
            Name = name;
            Description = description;
            Duration = duration;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public List<Pricing> Pricings { get; set; } = new();

    }
}