using ClinicHub.Core.Enums;

namespace ClinicHub.Core.Entity
{
    public class CustomerService : BaseEntity
    {
        public CustomerService(int doctorId, int patientId, int serviceId, DateTime startAt, DateTime? endAt,
                               TypeServiceEnum typeService, StatusServiceEnum statusService, int consultationTypeId,
                               string? observations, int? paymentId)
        {
            DoctorId = doctorId;
            PatientId = patientId;
            ServiceId = serviceId;
            StartAt = startAt;
            EndAt = endAt;
            TypeService = typeService;
            StatusService = statusService;
            ConsultationTypeId = consultationTypeId;
            Observations = observations;
            PaymentId = paymentId;
        }

        public int DoctorId { get; private set; }
        public int PatientId { get; private set; }
        public int ServiceId { get; private set; }        
        public DateTime StartAt { get; private set; }
        public DateTime? EndAt { get; private set; }
        public TypeServiceEnum TypeService { get; private set; }
        public StatusServiceEnum StatusService { get; private set; }
        public int ConsultationTypeId { get; private set; }
        public string? Observations { get; private set; }
        public int? PaymentId { get; private set; }        
        public Doctor Doctor { get; private set; }
        public Patient Patient { get; private set; }
        public Service Service { get; private set; }
        public ConsultationType ConsultationType { get; private set; }
    }
}
