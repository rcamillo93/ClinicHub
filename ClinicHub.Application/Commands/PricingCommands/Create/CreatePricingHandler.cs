using ClinicHub.Application.Models;
using ClinicHub.Core.Repositores;
using MediatR;

namespace ClinicHub.Application.Commands.PricingCommands.Create
{
    public class CreatePricingHandler : IRequestHandler<CreatePricingCommand, ResultViewModel<int>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreatePricingHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultViewModel<int>> Handle(CreatePricingCommand request, CancellationToken cancellationToken)
        {
            var pricing = request.ToEntiy();

            await _unitOfWork.Pricings.AddAsync(pricing);

            return ResultViewModel<int>.Sucess(await _unitOfWork.CompleteAsync());
        }
    }
}