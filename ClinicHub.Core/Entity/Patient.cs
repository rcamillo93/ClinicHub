using ClinicHub.Core.Enums;

namespace ClinicHub.Core.Entity
{
    public class Patient : BaseEntity
    {
        public Patient(string name, string lastName, DateTime birthDate, string phone, string email, string cPF,
                    decimal? weight, decimal? height, BloodTypeEnum? bloodType, RHFactorEnum? rhFactor, int addressId)
        {
            Name = name;
            LastName = lastName;
            BirthDate = birthDate;
            Phone = phone;
            Email = email;
            CPF = cPF;
            Weight = weight;
            Height = height;
            BloodType = bloodType;
            RhFactor = rhFactor;
            AddressId = addressId;
        }

        public string Name { get; private set; }
        public string LastName { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public string CPF { get; private set; }
        public decimal? Weight { get; private set; }
        public decimal? Height { get; private set; }
        public BloodTypeEnum? BloodType { get; private set; }
        public RHFactorEnum? RhFactor { get; private set; }
        public int AddressId { get; private set; }
    }
}
