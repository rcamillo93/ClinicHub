namespace ClinicHub.Core.Entity
{
    public class Service : BaseEntity
    {
        public Service(string name, string description, decimal value, int duration)
        {
            Name = name;
            Description = description;
            Value = value;
            Duration = duration;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Value { get; private set; }
        public int Duration { get; private set; }
    }
}
