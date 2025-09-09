using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using MediatR;

namespace ClinicHub.Application.Queries.SpecialtyByIdQueries.GetAll
{
    public class GetAllSpecialtiesQuery : IRequest<ResultViewModel<List<SpecialtyViewModel>>>
    {
        public GetAllSpecialtiesQuery(string? name)
        {
            Name = name;
        }

        public string? Name { get; set; }
     
    }
}