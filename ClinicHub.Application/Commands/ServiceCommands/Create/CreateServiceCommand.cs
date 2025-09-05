using ClinicHub.Application.Models;
using ClinicHub.Core.Entity;
using MediatR;

namespace ClinicHub.Application.Commands.ServiceCommands.Create
{
    public class CreateServiceCommand : IRequest<ResultViewModel<int>>
    {
        public CreateServiceCommand(string name, string description, int duration)
        {
            Name = name;
            Description = description;
            Duration = duration;
        }

        public string Name { get; set; }
        public string Description { get; set; }       
        public int Duration { get; set; }

        public Service ToEntity()
        {
            return new Service(Name, Description, Duration);
        }
    }
}