using ClinicHub.Application.Models;
using ClinicHub.Core.Entity;
using ClinicHub.Core.Repositores;
using MediatR;

namespace ClinicHub.Application.Commands.UserCommands.Create
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, ResultViewModel<int>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateUserHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultViewModel<int>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = request.ToEntity();

            await _unitOfWork.Users.AddAsync(user);

            await _unitOfWork.CompleteAsync();

            return ResultViewModel<int>.Sucess(user.Id);
        }
    }    
}