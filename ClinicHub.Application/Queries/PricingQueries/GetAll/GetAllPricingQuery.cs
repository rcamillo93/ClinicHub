using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using MediatR;

namespace ClinicHub.Application.Queries.PricingQueries.GetAll
{
    public class GetAllPricingQuery : IRequest<ResultViewModel<List<PricingViewModel>>>
    {        
        public int? HealthInsuranceId { get; set; }
        public int? SpecialtyId { get; set; }
        public int? ConsultationTypeId { get; set; }
    }
}