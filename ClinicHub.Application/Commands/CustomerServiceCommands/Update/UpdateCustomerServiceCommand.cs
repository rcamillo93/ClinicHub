using ClinicHub.Application.Models;
using ClinicHub.Core.Enums;
using MediatR;

namespace ClinicHub.Application.Commands.CustomerServiceCommands.Update
{
    public class UpdateCustomerServiceCommand : IRequest<ResultViewModel>
    {
        public UpdateCustomerServiceCommand(int id, int doctorId, int patientId, int serviceId, DateTime startAt, 
                                            DateTime? endAt, TypeServiceEnum typeService, StatusServiceEnum statusService,
                                            int consultationTypeId, decimal value, string? observations, int? paymentId)
        {
            Id = id;
            DoctorId = doctorId;
            PatientId = patientId;
            ServiceId = serviceId;
            StartAt = startAt;
            EndAt = endAt;
            TypeService = typeService;
            StatusService = statusService;
            ConsultationTypeId = consultationTypeId;
            Value = value;
            Observations = observations;
            PaymentId = paymentId;
        }

        public int Id { get; private set; }
        public int DoctorId { get; private set; }
        public int PatientId { get; private set; }
        public int ServiceId { get; private set; }
        public DateTime StartAt { get; private set; }
        public DateTime? EndAt { get; private set; }
        public TypeServiceEnum TypeService { get; private set; }
        public StatusServiceEnum StatusService { get; private set; }
        public int ConsultationTypeId { get; private set; }
        public decimal Value { get; private set; }
        public string? Observations { get; private set; }
        public int? PaymentId { get; private set; }
    }
}
