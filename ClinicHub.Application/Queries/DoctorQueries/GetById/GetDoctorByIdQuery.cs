using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using MediatR;

namespace ClinicHub.Application.Queries.DoctorQueries.GetById
{
    public class GetDoctorByIdQuery : IRequest<ResultViewModel<DoctorViewModel>>
    {
        public GetDoctorByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}