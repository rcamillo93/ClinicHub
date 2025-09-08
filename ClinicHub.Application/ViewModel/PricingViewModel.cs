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

    }
}