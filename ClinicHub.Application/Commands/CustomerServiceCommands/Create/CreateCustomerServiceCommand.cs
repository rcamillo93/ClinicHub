using ClinicHub.Application.Models;
using ClinicHub.Core.Entity;
using ClinicHub.Core.Enums;
using MediatR;

namespace ClinicHub.Application.Commands.CustomerServiceCommands.Create
{
    public class CreateCustomerServiceCommand : IRequest<ResultViewModel<int>>
    {
        public CreateCustomerServiceCommand(int doctorId, int patientId, int serviceId, DateTime startAt,
                                            DateTime? endAt, TypeServiceEnum typeService, int consultationTypeId,
                                            decimal value, string? observations, int? paymentId)
        {
            DoctorId = doctorId;
            PatientId = patientId;
            ServiceId = serviceId;
            StartAt = startAt;
            EndAt = endAt;
            TypeService = typeService;            
            ConsultationTypeId = consultationTypeId;
            StatusService = StatusServiceEnum.Scheduled;
            Value = value;
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
        public decimal Value { get; private set; }
        public string? Observations { get; private set; }
        public int? PaymentId { get; private set; }

        public CustomerService ToEntity()
        {
            return new CustomerService(DoctorId, PatientId, ServiceId, StartAt, EndAt, TypeService,
                                       ConsultationTypeId, Value, Observations, PaymentId);
        }
    }
}
