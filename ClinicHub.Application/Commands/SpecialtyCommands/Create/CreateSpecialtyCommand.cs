using ClinicHub.Application.Models;
using MediatR;

namespace ClinicHub.Application.Commands.SpecialtyCommands.Create
{
    public class CreateSpecialtyCommand : IRequest<ResultViewModel<int>>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Duration { get; set; }
    }
}