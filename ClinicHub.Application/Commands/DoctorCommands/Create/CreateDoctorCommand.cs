using ClinicHub.Application.Models;
using ClinicHub.Core.Entity;
using ClinicHub.Core.Enums;
using MediatR;

namespace ClinicHub.Application.Commands.DoctorCommands.Create
{
    public class CreateDoctorCommand : IRequest<ResultViewModel<int>>
    {
        public CreateDoctorCommand(string fullName, string email, string password, DateTime birthDate, 
                            string phone, string cpf, string crm, BloodTypeEnum? bloodType, 
                            RHFactorEnum? rhFactor, int specialtyId, int addressId)
        {
            FullName = fullName;
            Email = email;
            Password = password;
            BirthDate = birthDate;
            Phone = phone;
            Cpf = cpf;
            Crm = crm;
            BloodType = bloodType;
            RhFactor = rhFactor;
            SpecialtyId = specialtyId;
            AddressId = addressId;
        }

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Cpf { get; set; }
        public string Crm { get; set; }
        public BloodTypeEnum? BloodType { get; set; }
        public RHFactorEnum? RhFactor { get; set; }
        public int SpecialtyId { get; set; }
        public int AddressId { get; set; }

        public Doctor ToEntity(int userId)
        {
            return new Doctor(
                userId,
                Crm,
                BloodType,
                RhFactor,
                SpecialtyId,
                AddressId
            );
        }
    }
}
