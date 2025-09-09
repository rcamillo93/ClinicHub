using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using MediatR;

namespace ClinicHub.Application.Queries.ServicesQueries.GetAll
{
    public class GetAllServicesQuery : IRequest<ResultViewModel<List<ServiceViewModel>>>
    {
        public GetAllServicesQuery(string? name)
        {
            Name = name;
        }

        public string? Name { get; set; }
    }
}