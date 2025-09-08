using ClinicHub.Core.Entity;

namespace ClinicHub.Application.ViewModel
{
    public class PatientViewModel
    {
        public PatientViewModel(string fullName, string phone, string email, Address? address)
        {
            FullName = fullName;
            Phone = phone;
            Email = email;
            Address = address;
        }

        public PatientViewModel()
        {
            
        }

        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Address? Address { get; set; }

        public PatientViewModel FromEntity(Patient patient)
        {
            return new PatientViewModel(patient.FullName, patient.Phone, patient.Email, patient.Address);
        }
    }
}
