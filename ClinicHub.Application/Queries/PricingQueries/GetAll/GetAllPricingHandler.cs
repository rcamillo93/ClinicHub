using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using ClinicHub.Core.Repositores;
using MediatR;

namespace ClinicHub.Application.Queries.PricingQueries.GetAll
{
    public class GetAllPricingHandler : IRequestHandler<GetAllPricingQuery, ResultViewModel<List<PricingViewModel>>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllPricingHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultViewModel<List<PricingViewModel>>> Handle(GetAllPricingQuery request, CancellationToken cancellationToken)
        {
            var pricing = await _unitOfWork.Pricings.GetAllAsync(request.HealthInsuranceId, request.SpecialtyId, request.ConsultationTypeId);

            var viewModel = pricing.Select(p => new PricingViewModel().FromEntity(p)).ToList();

            return new ResultViewModel<List<PricingViewModel>>(viewModel);
        }
    }
}