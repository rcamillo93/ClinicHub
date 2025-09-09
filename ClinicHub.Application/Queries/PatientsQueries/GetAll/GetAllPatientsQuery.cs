using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using MediatR;

namespace ClinicHub.Application.Queries.PatientsQueries.GetAll
{
    public class GetAllPatientsQuery : IRequest<ResultViewModel<List<PatientViewModel>>>
    {
        public GetAllPatientsQuery(string? name)
        {
            Name = name;
        }

        public string? Name { get; set; }
    }
}