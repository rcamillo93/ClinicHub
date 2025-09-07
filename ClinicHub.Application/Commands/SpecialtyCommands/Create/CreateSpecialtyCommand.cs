using ClinicHub.Application.Models;
using MediatR;

namespace ClinicHub.Application.Commands.SpecialtyCommands.Create
{
    public class CreateSpecialtyCommand : IRequest<ResultViewModel<int>>
    {
        public CreateSpecialtyCommand(string name, string description)
        {
            Name = name;
            Description = description;     
        }

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

    }
}