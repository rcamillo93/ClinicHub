using ClinicHub.Application.Models;
using ClinicHub.Core.Entity;
using ClinicHub.Core.Enums;
using MediatR;

namespace ClinicHub.Application.Commands.PatientCommands.Create
{
    public class CreatePatientCommand : IRequest<ResultViewModel<int>>
    {
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string Phone { get; private set; }
        public string CPF { get; private set; }
        public char Gender { get; private set; }
        public decimal? Weight { get; private set; }
        public decimal? Height { get; private set; }
        public BloodTypeEnum? BloodType { get; private set; }
        public RHFactorEnum? RhFactor { get; private set; }
        public int? AddressId { get; private set; }
        public int? HealthInsuranceId { get; private set; }

        public Patient ToEntity()
        {
            return new Patient(FullName, Email, BirthDate, Phone, Gender);
        }
    }
}