using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using MediatR;

namespace ClinicHub.Application.Queries.SpecialtyByIdQueries.GetById
{
    public class GetSpecialtyByIdQuery : IRequest<ResultViewModel<SpecialtyViewModel>>
    {
        public GetSpecialtyByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}