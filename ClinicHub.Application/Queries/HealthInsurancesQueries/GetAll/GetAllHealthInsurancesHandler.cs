using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using ClinicHub.Core.Repositores;
using MediatR;

namespace ClinicHub.Application.Queries.HealthInsurancesQueries.GetAll
{
    public class GetAllHealthInsurancesHandler : IRequestHandler<GetAllHealthInsurancesQuery, ResultViewModel<List<HealthInsuranceViewModel>>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllHealthInsurancesHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultViewModel<List<HealthInsuranceViewModel>>> Handle(GetAllHealthInsurancesQuery request, CancellationToken cancellationToken)
        {
            var healthInsurances =  await _unitOfWork.HealthInsurances.GetAllAsync(request.Name);

            var viewModel = healthInsurances
                            .Select(h => new HealthInsuranceViewModel(h.Id, h.Name, h.Description, h.Validity));

            return ResultViewModel<List<HealthInsuranceViewModel>>.Success(viewModel.ToList());
        }
    }
}