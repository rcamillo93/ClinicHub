using ClinicHub.Application.Models;
using MediatR;

namespace ClinicHub.Application.Commands.ConsultationTypeCommands.Update
{
    public class UpdateConsultationTypeCommad : IRequest<ResultViewModel>
    {
        public UpdateConsultationTypeCommad(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
    }
}
