using ClinicHub.Application.Models;
using MediatR;

namespace ClinicHub.Application.Commands.ConsultationTypeCommands.Create
{
    public class CreateConsultationTypeCommad : IRequest<ResultViewModel<int>>
    {
        public CreateConsultationTypeCommad(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public string Title { get; private set; }
        public string Description { get; private set; }
    }
}
