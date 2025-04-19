using ClinicHub.Core.Enums;

namespace ClinicHub.Core.Entity
{
    public class Doctor : UserBaseEntity
    {
        public Doctor()
        {
        }

        public Doctor(string fullName, string email, string password, DateTime birthDate, string phone, string cPF,
               string crm, BloodTypeEnum? bloodType, RHFactorEnum? rhFactor, int specialtyId, int addressId)
            : base(fullName, email, password, birthDate, phone, cPF, UserRoleEnum.Doctor)
        {
            CRM = crm;
            BloodType = bloodType;
            RhFactor = rhFactor;
            SpecialtyId = specialtyId;
            AddressId = addressId;
            CustomerServices = new List<CustomerService>();
        }

        public string CRM { get; private set; }
        public BloodTypeEnum? BloodType { get; private set; }
        public RHFactorEnum? RhFactor { get; private set; }
        public int SpecialtyId { get; private set; }
        public int AddressId { get; private set; }
        public Address? Address { get; private set; }
        public Specialty? Specialty { get; private set; }
        public List<CustomerService> CustomerServices { get; private set; }        
    }
}
