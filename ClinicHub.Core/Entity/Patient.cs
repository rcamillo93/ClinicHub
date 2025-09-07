using ClinicHub.Core.Enums;

namespace ClinicHub.Core.Entity
{
    public class Patient : BaseEntity
    {
        public Patient(string fullName, string email, DateTime birthDate, string phone,
                       string cPF, char gender, decimal? weight, decimal? height,
                       BloodTypeEnum? bloodType, RHFactorEnum? rhFactor,
                       int? addressId, int? healthInsuranceId)
        {
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            Phone = phone;
            CPF = cPF;
            Gender = gender;
            Weight = weight;
            Height = height;
            BloodType = bloodType;
            RhFactor = rhFactor;
            AddressId = addressId;
            HealthInsuranceId = healthInsuranceId;
            CustomerServices = new List<CustomerService>();
        }

        public Patient(string fullName, string email,
                    DateTime birthDate, string phone, char gender)
        {
            FullName = fullName;
            Email = email;
            BirthDate = birthDate;
            Phone = phone;
            Gender = gender;    
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Phone { get; private set; }        
        public string CPF { get; private set; }
        public char Gender { get; private set; }
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
