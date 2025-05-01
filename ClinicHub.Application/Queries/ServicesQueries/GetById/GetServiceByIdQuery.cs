using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using MediatR;

namespace ClinicHub.Application.Queries.ServicesQueries.GetById
{
    public class GetServiceByIdQuery : IRequest<ResultViewModel<ServiceViewModel>>
    {
        public GetServiceByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}