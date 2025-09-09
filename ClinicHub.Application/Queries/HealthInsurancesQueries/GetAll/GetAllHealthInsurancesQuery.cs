using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using ClinicHub.Core.Entity;
using MediatR;

namespace ClinicHub.Application.Queries.HealthInsurancesQueries.GetAll
{
    public class GetAllHealthInsurancesQuery : IRequest<ResultViewModel<List<HealthInsuranceViewModel>>>
    {
        public GetAllHealthInsurancesQuery(string? name)
        {
            Name = name;
        }

        public string? Name { get; set; }
    }
}
