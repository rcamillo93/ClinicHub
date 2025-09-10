using ClinicHub.Core.Enums;

namespace ClinicHub.Core.Entity
{
    public class Doctor : BaseEntity
    {
        public Doctor(int userId, string crm, BloodTypeEnum? bloodType, RHFactorEnum? rhFactor, int specialtyId, int? addressId)
        {
            UserId = userId;
            Crm = crm;
            BloodType = bloodType;
            RhFactor = rhFactor;
            SpecialtyId = specialtyId;
            AddressId = addressId;
            CustomerServices = new List<CustomerService>();
        }

        public int UserId { get; private set; }
        public User User { get; private set; } = null!;
        public string Crm { get; private set; }
        public BloodTypeEnum? BloodType { get; private set; }
        public RHFactorEnum? RhFactor { get; private set; }
        public int SpecialtyId { get; private set; }
        public int? AddressId { get; private set; }
        public Address? Address { get; private set; }
        public Specialty? Specialty { get; private set; }
        public List<CustomerService> CustomerServices { get; private set; }
    }
}