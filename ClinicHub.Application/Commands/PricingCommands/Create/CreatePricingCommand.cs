using ClinicHub.Application.Models;
using ClinicHub.Core.Entity;
using MediatR;

namespace ClinicHub.Application.Commands.PricingCommands.Create
{
    public class CreatePricingCommand : IRequest<ResultViewModel<int>>
    {
        public CreatePricingCommand(int serviceId, int? healthInsuranceId, int specialtyId,
                                    int consultationTypeId, decimal value)
        {
            ServiceId = serviceId;
            HealthInsuranceId = healthInsuranceId;
            SpecialtyId = specialtyId;
            ConsultationTypeId = consultationTypeId;
            Value = value;
        }

        public int ServiceId { get; private set; }
        public int? HealthInsuranceId { get; private set; }
        public int SpecialtyId { get; private set; }
        public int ConsultationTypeId { get; private set; }
        public decimal Value { get; private set; }

        public Pricing ToEntiy()
        {
            return new Pricing(ServiceId, SpecialtyId, ConsultationTypeId, HealthInsuranceId, Value);
        }
    }
}
