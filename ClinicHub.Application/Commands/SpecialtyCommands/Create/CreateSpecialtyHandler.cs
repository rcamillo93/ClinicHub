using ClinicHub.Application.Models;
using ClinicHub.Core.Entity;
using ClinicHub.Core.Repositores;
using MediatR;

namespace ClinicHub.Application.Commands.SpecialtyCommands.Create
{
    public class CreateSpecialtyHandler : IRequestHandler<CreateSpecialtyCommand, ResultViewModel<int>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateSpecialtyHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultViewModel<int>> Handle(CreateSpecialtyCommand request, CancellationToken cancellationToken)
        {
            var specialty = new Specialty(request.Name, request.Description);

            await _unitOfWork.Specialties.AddAsync(specialty);

            return new ResultViewModel<int>(await _unitOfWork.CompleteAsync());
        }
    }
}
