using ClinicHub.Application.Models;
using ClinicHub.Core.Entity;
using ClinicHub.Core.Repositores;
using ClinicHub.Core.Services;
using MediatR;

namespace ClinicHub.Application.Commands.UserCommands.Create
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, ResultViewModel<int>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IAuthService _authService;

        public CreateUserHandler(IUnitOfWork unitOfWork, IAuthService authService)
        {
            _unitOfWork = unitOfWork;
            _authService = authService;
        }

        public async Task<ResultViewModel<int>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var passwordHash = _authService.ComputeSha256Hash(request.Password);

            var user = request.ToEntity(passwordHash);

            await _unitOfWork.Users.AddAsync(user);

            await _unitOfWork.CompleteAsync();

            return ResultViewModel<int>.Sucess(user.Id);
        }
    }    
}