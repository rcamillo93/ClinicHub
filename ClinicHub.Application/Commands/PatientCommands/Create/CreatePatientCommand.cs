using ClinicHub.Application.Models;
using MediatR;

namespace ClinicHub.Application.Commands.PatientCommands.Create
{
    public class CreatePatientCommand : IRequest<ResultViewModel>
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public int GenderId { get; set; }
    }
}