using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using ClinicHub.Core.Repositores;
using MediatR;

namespace ClinicHub.Application.Queries.PricingQueries.GetById
{
    public class GetPricingByIdHandler : IRequestHandler<GetPricingByIdQuery, ResultViewModel<PricingViewModel>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetPricingByIdHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultViewModel<PricingViewModel>> Handle(GetPricingByIdQuery request, CancellationToken cancellationToken)
        {
            var pricing = await _unitOfWork.Pricings.GetByIdAsync(request.Id);

            if (pricing == null)
                return new ResultViewModel<PricingViewModel>(null, false, "Pricing not found.");

            return new ResultViewModel<PricingViewModel>(new PricingViewModel().FromEntity(pricing));
        }
    }
}