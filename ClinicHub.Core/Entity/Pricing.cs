namespace ClinicHub.Core.Entity
{
    public class Pricing : BaseEntity
    {
        public Pricing(int serviceId, int specialtyId, 
                        int consultationTypeId, int? healthInsuranceId, decimal value)
        {
            ServiceId = serviceId;
            SpecialtyId = specialtyId;
            ConsultationTypeId = consultationTypeId;
            HealthInsuranceId = healthInsuranceId;
            Value = value;  
        }

        public int ServiceId { get; private set; }
        public int? HealthInsuranceId { get; private set; }
        public int SpecialtyId { get; private set; }
        public int ConsultationTypeId { get; private set; }
        public decimal Value { get; private set; }

        public HealthInsurance? HealthInsurance { get; set; }
        public ConsultationType ConsultationType { get; set; }
        public Specialty Specialty { get; set; }
        public Service Service { get; set; }
    }
}
