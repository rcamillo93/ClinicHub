using ClinicHub.Core.Enums;

namespace ClinicHub.Core.Entity
{
    public class User : BaseEntity
    {
        public User(string fullName, string email, string password, DateTime birthDate, string phone, string cpf, UserRoleEnum role)
        {
            FullName = fullName;
            Email = email;
            Password = password;
            BirthDate = birthDate;
            Phone = phone;
            Cpf = cpf;
            Role = role;
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Phone { get; private set; }
        public string Cpf { get; private set; }
        public UserRoleEnum Role { get; private set; }
        public Doctor? Doctor { get; set; }
    }
}