using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using MediatR;

namespace ClinicHub.Application.Queries.PricingQueries.GetById
{
    public class GetPricingByIdQuery : IRequest<ResultViewModel<PricingViewModel>>
    {
        public GetPricingByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}