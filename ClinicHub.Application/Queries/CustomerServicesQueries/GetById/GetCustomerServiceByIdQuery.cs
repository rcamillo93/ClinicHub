using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using MediatR;

namespace ClinicHub.Application.Queries.CustomerServicesQueries.GetById
{
    public class GetCustomerServiceByIdQuery : IRequest<ResultViewModel<CustomerServiceViewModel>>
    {
        public int Id { get; set; }
        public GetCustomerServiceByIdQuery(int id)
        {
            Id = id;
        }
    }
}