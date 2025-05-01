using ClinicHub.Application.Models;
using MediatR;

namespace ClinicHub.Application.Commands.SpecialtyCommands.Delete
{
    public class DeleteSpecialtyCommand : IRequest<ResultViewModel>
    {
        public DeleteSpecialtyCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}