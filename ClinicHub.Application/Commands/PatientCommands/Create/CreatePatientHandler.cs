using ClinicHub.Application.Models;
using ClinicHub.Core.Repositores;
using MediatR;

namespace ClinicHub.Application.Commands.PatientCommands.Create
{
    public class CreatePatientHandler : IRequestHandler<CreatePatientCommand, ResultViewModel<int>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreatePatientHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultViewModel<int>> Handle(CreatePatientCommand request, CancellationToken cancellationToken)
        {
            var patient = request.ToEntity();

            await _unitOfWork.Patients.AddAsync(patient);

            return ResultViewModel<int>.Success(await _unitOfWork.CompleteAsync());
        }
    }
}