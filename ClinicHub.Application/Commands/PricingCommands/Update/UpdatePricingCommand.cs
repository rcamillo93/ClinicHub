using ClinicHub.Application.Models;
using MediatR;

namespace ClinicHub.Application.Commands.PricingCommands.Update
{
    public class UpdatePricingCommand : IRequest<ResultViewModel>
    {
        public UpdatePricingCommand(int id, int serviceId, int? healthInsuranceId, int specialtyId,
                                    int consultationTypeId, decimal value)
        {
            Id = id;
            ServiceId = serviceId;
            HealthInsuranceId = healthInsuranceId;
            SpecialtyId = specialtyId;
            ConsultationTypeId = consultationTypeId;
            Value = value;
        }

        public int Id { get; private set; }
        public int ServiceId { get; private set; }
        public int? HealthInsuranceId { get; private set; }
        public int SpecialtyId { get; private set; }
        public int ConsultationTypeId { get; private set; }
        public decimal Value { get; private set; }
    }
}
