using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using ClinicHub.Core.Repositores;
using MediatR;

namespace ClinicHub.Application.Queries.ServicesQueries.GetById
{
    public class GetServiceByIdHandler : IRequestHandler<GetServiceByIdQuery, ResultViewModel<ServiceViewModel>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetServiceByIdHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultViewModel<ServiceViewModel>> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var service = await _unitOfWork.Services.GetServiceByIdAsync(request.Id);

            if (service == null)
            {
                return ResultViewModel<ServiceViewModel>.Error("Service not found.");
            }

            var viewModel = new ServiceViewModel(service.Id, service.Name, service.Description, service.Duration);

            return ResultViewModel<ServiceViewModel>.Success(viewModel);
        }
    }
}