using ClinicHub.Core.Entity;

namespace ClinicHub.Application.ViewModel
{
    public class CustomerServiceViewModel
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public int ServiceId { get; set; }
        public int ConsultationTypeId { get; set; }
        public string DoctorName { get; set; }
        public string PatientName { get; set; }
        public DateOnly StartDate { get; set; }
        public TimeOnly StartHours { get; set; }
        public string ServiceName { get; set; }
        public string ServiceDescription { get; set; }
        public int ServiceDuration { get; set; }
        public TimeOnly EndHours { get; set; }
        public string? Observations { get; set; }

        public CustomerServiceViewModel FromEntity(CustomerService entity)
        {
            return new CustomerServiceViewModel
            {
                Id = entity.Id,
                DoctorId = entity.DoctorId,
                PatientId = entity.PatientId,
                ServiceId = entity.ServiceId,
                ConsultationTypeId = entity.ConsultationTypeId,
                DoctorName = entity.Doctor?.User?.FullName ?? string.Empty,
                PatientName = entity.Patient?.FullName ?? string.Empty,
                StartDate = DateOnly.Parse(entity.StartAt.ToString()),
                StartHours = TimeOnly.Parse(entity.StartAt.ToString("HH:mm")),
                ServiceName = entity.Service?.Name ?? string.Empty,
                ServiceDescription = entity.Service?.Description ?? string.Empty,
                ServiceDuration = entity.Service?.Duration ?? 0,
                EndHours = TimeOnly.Parse(entity.EndAt.ToString()),
                Observations = entity.Observations
            };
        }

    }
}