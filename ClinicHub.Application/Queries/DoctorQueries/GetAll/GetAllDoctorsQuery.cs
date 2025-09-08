using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using MediatR;

namespace ClinicHub.Application.Queries.DoctorQueries.GetAll
{
    public class GetAllDoctorsQuery : IRequest<ResultViewModel<List<DoctorViewModel>>>
    {
       public string? Name { get; set; }
        
    }
}