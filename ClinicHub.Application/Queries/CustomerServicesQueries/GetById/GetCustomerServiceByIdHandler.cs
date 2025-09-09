using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using ClinicHub.Core.Repositores;
using MediatR;

namespace ClinicHub.Application.Queries.CustomerServicesQueries.GetById
{
    public class GetCustomerServiceByIdHandler : IRequestHandler<GetCustomerServiceByIdQuery, ResultViewModel<CustomerServiceViewModel>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetCustomerServiceByIdHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultViewModel<CustomerServiceViewModel>> Handle(GetCustomerServiceByIdQuery request, CancellationToken cancellationToken)
        {
            var customerService = await _unitOfWork.CustomerServices.GetCustomerServiceByIdAsync(request.Id);

            if (customerService == null)
            {
                return ResultViewModel<CustomerServiceViewModel>.Error("Customer service not found.");
            }

            var viewModel = new CustomerServiceViewModel().FromEntity(customerService);

            return ResultViewModel<CustomerServiceViewModel>.Success(viewModel);
        }
    }
}