using ClinicHub.Application.Models;
using ClinicHub.Core.Repositores;
using MediatR;

namespace ClinicHub.Application.Commands.CustomerServiceCommands.Create
{
    public class CreateCustomerServiceHandler : IRequestHandler<CreateCustomerServiceCommand, ResultViewModel<int>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateCustomerServiceHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultViewModel<int>> Handle(CreateCustomerServiceCommand request, CancellationToken cancellationToken)
        {
            var customerService = request.ToEntity();

            await _unitOfWork.CustomerServices.AddAsync(customerService);

            return ResultViewModel<int>.Sucess(await _unitOfWork.CompleteAsync());
        }
    }
}