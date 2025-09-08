using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using MediatR;

namespace ClinicHub.Application.Queries.CustomerServicesQueries.GetAll
{
    public class GetAllCustomerServicesQuery : IRequest<ResultViewModel<List<CustomerServiceViewModel>>>
    {
        public DateOnly? StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public string? DoctorName { get; set; }
        public string? PatientName { get; set; }
        public int? ConsultationTypeId { get; set; }
    }
}