using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using ClinicHub.Core.Repositores;
using MediatR;

namespace ClinicHub.Application.Queries.CustomerServicesQueries.GetAll
{
    public class GetAllCustomerServicesHandler : IRequestHandler<GetAllCustomerServicesQuery, ResultViewModel<List<CustomerServiceViewModel>>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllCustomerServicesHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultViewModel<List<CustomerServiceViewModel>>> Handle(GetAllCustomerServicesQuery request, CancellationToken cancellationToken)
        {
            var customerServices = await _unitOfWork.CustomerServices.GetAllAsync(request.StartDate, request.EndDate, request.PatientName, request.DoctorName);

            var viewModel = new CustomerServiceViewModel();

            return ResultViewModel<List<CustomerServiceViewModel>>.Success(customerServices.Select(cs => viewModel.FromEntity(cs)).ToList());
        }
    }
}
