using ClinicHub.Application.Models;
using MediatR;

namespace ClinicHub.Application.Commands.DoctorCommands.Delete
{
    public class DeleteDoctorCommand : IRequest<ResultViewModel>
    {
        public DeleteDoctorCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}