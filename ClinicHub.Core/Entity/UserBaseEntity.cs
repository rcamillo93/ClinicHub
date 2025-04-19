using ClinicHub.Core.Enums;

namespace ClinicHub.Core.Entity
{
    public abstract class UserBaseEntity : BaseEntity
    {
        protected UserBaseEntity() : base()
        {
        }

        protected UserBaseEntity(string fullName, string email, string password, DateTime birthDate,
                                    string phone, string cPF, UserRoleEnum role)
        {
            FullName = fullName;
            Email = email;
            Password = password;
            BirthDate = birthDate;
            Phone = phone;
            CPF = cPF;
            Role = role;
        }

        public string FullName { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        public DateTime BirthDate { get; protected set; }
        public string Phone { get; protected set; }
        public string CPF { get; protected set; }
        public UserRoleEnum Role { get; protected set; }
    }
}