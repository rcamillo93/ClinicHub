using ClinicHub.Core.Enums;

namespace ClinicHub.Core.Entity
{
    public class CustomerService : BaseEntity
    {
        public CustomerService(int doctorId, int patientId, int serviceId, int healthInsuranceId, DateTime startAt, DateTime? endAt, TypeServiceEnum typeService)
        {
            DoctorId = doctorId;
            PatientId = patientId;
            ServiceId = serviceId;
            HealthInsuranceId = healthInsuranceId;
            StartAt = startAt;
            EndAt = endAt;
            TypeService = typeService;
        }

        public int DoctorId { get; private set; }
        public int PatientId { get; private set; }
        public int ServiceId { get; private set; }
        public int HealthInsuranceId { get; private set; }
        public DateTime StartAt { get; private set; }
        public DateTime? EndAt { get; private set; }
        public TypeServiceEnum TypeService { get; private set; }
    }
}
