using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using MediatR;

namespace ClinicHub.Application.Queries.SpecialtyByIdQueries.GetAll
{
    public class GetAllSpecialtiesQuery : IRequest<ResultViewModel<List<SpecialtyViewModel>>>
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Duration { get; set; }
        public int? ServiceId { get; set; }
        public int? PatientId { get; set; }
        public int? DoctorId { get; set; }
        public int? ClinicId { get; set; }
        public int? SpecialtyId { get; set; }
        public int? GenderId { get; set; }
    }
}