using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using ClinicHub.Core.Repositores;
using MediatR;

namespace ClinicHub.Application.Queries.ServicesQueries.GetAll
{
    public class GetAllServicesHandler : IRequestHandler<GetAllServicesQuery, ResultViewModel<List<ServiceViewModel>>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllServicesHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultViewModel<List<ServiceViewModel>>> Handle(GetAllServicesQuery request, CancellationToken cancellationToken)
        {
            var services = await _unitOfWork.Services.GetAllAsync(request.Name);

            var viewModel = services.Select(s => new ServiceViewModel(s.Id, s.Name, s.Description, s.Duration));

            return ResultViewModel<List<ServiceViewModel>>.Success(viewModel.ToList());
        }
    }
}
