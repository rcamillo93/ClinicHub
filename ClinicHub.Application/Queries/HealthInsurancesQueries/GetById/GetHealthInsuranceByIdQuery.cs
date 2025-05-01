using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;

using MediatR;

namespace ClinicHub.Application.Queries.HealthInsurancesQueries.GetById
{
    public class GetHealthInsuranceByIdQuery : IRequest<ResultViewModel<HealthInsuranceViewModel>>
    {
        public GetHealthInsuranceByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
