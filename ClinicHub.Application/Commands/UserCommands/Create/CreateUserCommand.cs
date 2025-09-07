using ClinicHub.Application.Models;
using ClinicHub.Core.Entity;
using ClinicHub.Core.Enums;
using MediatR;

namespace ClinicHub.Application.Commands.UserCommands.Create
{
    public class CreateUserCommand : IRequest<ResultViewModel<int>>
    {
        public CreateUserCommand(string fullName, string email, string password, DateTime birthDate,
                                string phone, string cpf, UserRoleEnum role)
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

        public User ToEntity(string passwordHash)
        {
            return new User(FullName, Email, passwordHash, BirthDate, Phone, Cpf, Role);
        }
    }
}
