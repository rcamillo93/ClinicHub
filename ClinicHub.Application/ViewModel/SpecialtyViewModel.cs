using ClinicHub.Core.Entity;

namespace ClinicHub.Application.ViewModel
{
    public class SpecialtyViewModel
    {
        public SpecialtyViewModel(int id, string name, string description, DateTime createdAt)
        {
            Id = id;
            Name = name;
            Description = description;
            CreatedAt = createdAt;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}