using ClinicHub.Application.Models;
using MediatR;

namespace ClinicHub.Application.Commands.DoctorCommands.Update
{
    public class UpdateDoctorCommand : IRequest<ResultViewModel<int>>
    {
        public int Id { get; set; }
    }
}