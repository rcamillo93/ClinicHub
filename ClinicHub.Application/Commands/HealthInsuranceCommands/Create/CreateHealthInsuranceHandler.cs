using ClinicHub.Application.Models;
using ClinicHub.Core.Entity;
using ClinicHub.Core.Repositores;
using MediatR;

namespace ClinicHub.Application.Commands.HealthInsuranceCommands.Create
{
    public class CreateHealthInsuranceHandler : IRequestHandler<CreateHealthInsuranceCommand, ResultViewModel<int>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateHealthInsuranceHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultViewModel<int>> Handle(CreateHealthInsuranceCommand request, CancellationToken cancellationToken)
        {
            var healthInsurance = new HealthInsurance(request.Name, request.Description, request.Validity);

            await _unitOfWork.HealthInsurances.AddAsync(healthInsurance);
            
            return ResultViewModel<int>.Success(await _unitOfWork.CompleteAsync());
        }
    }
}
