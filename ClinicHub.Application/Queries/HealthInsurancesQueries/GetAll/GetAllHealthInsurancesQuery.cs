using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using ClinicHub.Core.Entity;
using MediatR;

namespace ClinicHub.Application.Queries.HealthInsurancesQueries.GetAll
{
    public class GetAllHealthInsurancesQuery : IRequest<ResultViewModel<List<HealthInsuranceViewModel>>>
    {
        public string? Name { get; set; }
    }
}
