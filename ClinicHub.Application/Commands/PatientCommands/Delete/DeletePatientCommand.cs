using ClinicHub.Application.Models;
using MediatR;

namespace ClinicHub.Application.Commands.PatientCommands.Delete
{
    public class DeletePatientCommand : IRequest<ResultViewModel>
    {
        public int Id { get; set; }
        public string Reason { get; set; } = string.Empty;
        public DateTime DeletionDate { get; set; } = DateTime.UtcNow;
    }
}