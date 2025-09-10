using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using MediatR;

namespace ClinicHub.Application.Queries.CustomerServicesQueries.GetAll
{
    public class GetAllCustomerServicesQuery : IRequest<ResultViewModel<List<CustomerServiceViewModel>>>
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? DoctorName { get; set; }
        public string? PatientName { get; set; }
        public int? ConsultationTypeId { get; set; }
    }
}