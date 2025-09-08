using ClinicHub.Core.Entity;

namespace ClinicHub.Application.ViewModel
{
    public class ConsultationTypeViewModel 
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<CustomerService> CustomerServices { get; set; }
    }
}