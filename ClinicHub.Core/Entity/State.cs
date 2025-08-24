namespace ClinicHub.Core.Entity
{
    public class State : BaseEntity
    {
        public State(string stateName, string stateCode)
        {
            StateName = stateName;
            StateCode = stateCode;
            Cities = new List<City>();
        }

        public string StateName { get; private set; }
        public string StateCode { get; private set; }
        public List<City> Cities { get; private set; }
    }
}
