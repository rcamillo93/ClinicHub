using ClinicHub.Core.Enums;

namespace ClinicHub.Core.Entity
{
    public class Doctor : BaseEntity
    {
        public Doctor(string name, string lastName, string email, string cPF, string phone,
                        DateTime birthDate, string cRM, BloodTypeEnum? bloodType, RHFactorEnum? 
                        rhFactor, int specialtyId, int addressId)
        {
            Name = name;
            LastName = lastName;
            Email = email;
            CPF = cPF;
            Phone = phone;
            BirthDate = birthDate;
            CRM = cRM;
            BloodType = bloodType;
            RhFactor = rhFactor;
            SpecialtyId = specialtyId;
            AddressId = addressId;
        }

        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string CPF { get; private set; }
        public string Phone { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string CRM { get; private set; }
        public BloodTypeEnum? BloodType { get; private set; }
        public RHFactorEnum? RhFactor { get; private set; }
        public int SpecialtyId { get; private set; }
        public int AddressId { get; private set; }
    }
}
