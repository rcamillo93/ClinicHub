namespace ClinicHub.Core.Entity
{
    public class Specialty : BaseEntity
    {
        public Specialty(string name, string description)
        {
            Name = name;
            Description = description;
            Doctors = new List<Doctor>();
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public List<Doctor> Doctors { get; private set; }
    }
}
