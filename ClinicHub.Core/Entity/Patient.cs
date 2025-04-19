using ClinicHub.Core.Enums;

namespace ClinicHub.Core.Entity
{
    public class Patient : BaseEntity
    {
        public Patient(string fullName, DateTime birthDate, string phone, string email, string cPF, 
                        decimal? weight, decimal? height, BloodTypeEnum? bloodType, RHFactorEnum? rhFactor, 
                        int? addressId, int? healthInsuranceId)
        {
            FullName = fullName;
            BirthDate = birthDate;
            Phone = phone;
            Email = email;
            CPF = cPF;
            Weight = weight;
            Height = height;
            BloodType = bloodType;
            RhFactor = rhFactor;
            AddressId = addressId;
            HealthInsuranceId = healthInsuranceId;
        }

        public string FullName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public string CPF { get; private set; }
        public decimal? Weight { get; private set; }
        public decimal? Height { get; private set; }
        public BloodTypeEnum? BloodType { get; private set; }
        public RHFactorEnum? RhFactor { get; private set; }
        public int? AddressId { get; private set; }
        public int? HealthInsuranceId { get; private set; }
        public HealthInsurance HealthInsurance { get; private set; }
        public Address? Address { get; private set; }
        public List<CustomerService> CustomerServices { get; set; }
    }
}
