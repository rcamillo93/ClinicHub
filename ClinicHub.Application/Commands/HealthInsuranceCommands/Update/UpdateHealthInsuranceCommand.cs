using ClinicHub.Application.Models;
using MediatR;

namespace ClinicHub.Application.Commands.HealthInsuranceCommands.Update
{
    public class UpdateHealthInsuranceCommand : IRequest<ResultViewModel>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Duration { get; set; }
    }
}