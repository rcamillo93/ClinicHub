using ClinicHub.Application.Models;
using ClinicHub.Core.Entity;
using ClinicHub.Core.Repositores;
using MediatR;

namespace ClinicHub.Application.Commands.ConsultationTypeCommands.Create
{
    public class CreateConsultationTypeHandler : IRequestHandler<CreateConsultationTypeCommad, ResultViewModel<int>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateConsultationTypeHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultViewModel<int>> Handle(CreateConsultationTypeCommad request, CancellationToken cancellationToken)
        {
            var consultationType = new ConsultationType(request.Title, request.Description);

            await _unitOfWork.ConsultationTypes.AddAsync(consultationType);

            return ResultViewModel<int>.Sucess(await _unitOfWork.CompleteAsync());
        }
    }
}
