using ClinicHub.Application.Models;
using ClinicHub.Core.Repositores;
using MediatR;

namespace ClinicHub.Application.Commands.ServiceCommands.Create
{
    public class CreateServiceHandler : IRequestHandler<CreateServiceCommand, ResultViewModel<int>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateServiceHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultViewModel<int>> Handle(CreateServiceCommand request, CancellationToken cancellationToken)
        {
            var serivce = request.ToEntity();

            await _unitOfWork.Services.AddAsync(serivce);
            await _unitOfWork.CompleteAsync();

            return ResultViewModel<int>.Sucess(serivce.Id);
        }
    }
}
