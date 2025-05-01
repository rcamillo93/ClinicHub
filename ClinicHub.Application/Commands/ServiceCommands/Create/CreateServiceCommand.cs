using ClinicHub.Application.Models;
using MediatR;

namespace ClinicHub.Application.Commands.ServiceCommands.Create
{
    public class CreateServiceCommand : IRequest<ResultViewModel<int>>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Duration { get; set; }
    }
}