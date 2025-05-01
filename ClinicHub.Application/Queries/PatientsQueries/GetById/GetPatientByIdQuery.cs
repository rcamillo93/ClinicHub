using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using MediatR;

namespace ClinicHub.Application.Queries.PatientsQueries.GetById
{
    public class GetPatientByIdQuery : IRequest<ResultViewModel<PatientViewModel>>
    {
        public int Id { get; set; }

        public GetPatientByIdQuery(int id)
        {
            Id = id;
        }
    }
}