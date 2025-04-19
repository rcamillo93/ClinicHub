namespace ClinicHub.Core.Entity
{
    public class State : BaseEntity
    {
        public State(string stateName)
        {
            StateName = stateName;
            Cities = new List<City>();
        }

        public string StateName { get; private set; }
        public List<City> Cities { get; private set; }
    }
}
