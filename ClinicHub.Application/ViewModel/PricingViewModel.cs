using ClinicHub.Core.Entity;

namespace ClinicHub.Application.ViewModel
{
    public class PricingViewModel
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public int ServiceId { get; set; }
        public int? HealthInsuranceId { get; set; }
        public string ConsultationType { get; set; }
        public string HealthInsurance { get; set; }

        public PricingViewModel FromEntity(Pricing pricing)
        {
            return new PricingViewModel
            {
                Id = pricing.Id,
                ServiceName = pricing.Service.Name,
                ServiceId = pricing.ServiceId,
                HealthInsuranceId = pricing.HealthInsuranceId,
                ConsultationType = pricing.ConsultationType.Description,
                HealthInsurance = pricing.HealthInsurance != null ? pricing.HealthInsurance.Name : "Private"
            };
        }

    }
}