using ClinicHub.Application.Models;
using MediatR;

namespace ClinicHub.Application.Commands.HealthInsuranceCommands.Delete
{
    public class DeleteHealthInsuranceCommand : IRequest<ResultViewModel>
    {
        public DeleteHealthInsuranceCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }      
    }
}