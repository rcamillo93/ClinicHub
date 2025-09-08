using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using ClinicHub.Core.Repositores;
using MediatR;

namespace ClinicHub.Application.Queries.HealthInsurancesQueries.GetById
{
    public class GetHealthInsuranceByIdHandler : IRequestHandler<GetHealthInsuranceByIdQuery, ResultViewModel<HealthInsuranceViewModel>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetHealthInsuranceByIdHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultViewModel<HealthInsuranceViewModel>> Handle(GetHealthInsuranceByIdQuery request, CancellationToken cancellationToken)
        {
            var healthInsurance = await _unitOfWork.HealthInsurances.GetHealthInsuranceByIdAsync(request.Id);

            if (healthInsurance == null)
            {
                return ResultViewModel<HealthInsuranceViewModel>.Error("Health insurance not found.");
            }

            var viewModel = new HealthInsuranceViewModel(healthInsurance.Id, healthInsurance.Name, healthInsurance.Description, healthInsurance.Validity);

            return ResultViewModel<HealthInsuranceViewModel>.Success(viewModel);
        }
    }
}
