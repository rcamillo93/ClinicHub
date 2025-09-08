using ClinicHub.Core.Entity;

namespace ClinicHub.Application.ViewModel
{
    public class DoctorViewModel
    {
        public int Id { get; private set; }
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string Crm { get; private set; }
        public Specialty? Specialty { get; private set; }
        public List<CustomerService> CustomerServices { get; private set; } = new();

        public DoctorViewModel FromEntity(Doctor doctor)
        {
            Id = doctor.Id;
            FullName = doctor.User.FullName;
            Email = doctor.User.Email;
            Phone = doctor.User.Phone;
            Crm = doctor.Crm;
            Specialty = doctor.Specialty;
            CustomerServices = doctor.CustomerServices;

            return this;
        }
    }
}