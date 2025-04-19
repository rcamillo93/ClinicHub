using ClinicHub.Core.Enums;

namespace ClinicHub.Core.Entity
{
    public class Secretary : UserBaseEntity
    {
        public Secretary(string fullName, string email, string password, DateTime birthDate, string phone, string cPF)
            : base(fullName, email, password, birthDate, phone, cPF, UserRoleEnum.Secretary)
        {
        }

        public void Update(string fullName, string email, string password, DateTime birthDate,
                           string phone, string cPF)
        {
            FullName = fullName;
            Email = email;
            Password = password;
            BirthDate = birthDate;
            Phone = phone;
            CPF = cPF;
        }
    }    
}
