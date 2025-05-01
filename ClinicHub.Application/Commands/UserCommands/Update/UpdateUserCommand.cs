using ClinicHub.Application.Models;
using MediatR;

namespace ClinicHub.Application.Commands.UserCommands.Update
{
    public class UpdateUserCommand : IRequest<ResultViewModel<int>>
    {
        public int Id { get; set; }
    }
}