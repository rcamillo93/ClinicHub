using ClinicHub.Application.Models;
using MediatR;

namespace ClinicHub.Application.Commands.SpecialtyCommands.Update
{
    public class UpdateSpecialtyCommand : IRequest<ResultViewModel>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Duration { get; set; }
    }
}