using ClinicHub.Application.Models;
using ClinicHub.Core.Entity;
using ClinicHub.Core.Repositores;
using MediatR;

namespace ClinicHub.Application.Commands.DoctorCommands.Create
{
    public class CreateDoctorHandler : IRequestHandler<CreateDoctorCommand, ResultViewModel<int>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateDoctorHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultViewModel<int>> Handle(CreateDoctorCommand request, CancellationToken cancellationToken)
        {
            var user = new User(request.FullName, request.Email, request.Password, request.BirthDate, request.Phone,
                                request.Cpf, Core.Enums.UserRoleEnum.Doctor);

            await _unitOfWork.Users.AddAsync(user);

            var doctor = request.ToEntity(user.Id);

            await _unitOfWork.Users.AddDoctor(doctor);

            var result = await _unitOfWork.CompleteAsync();

            if(result == 0)
                return ResultViewModel<int>.Error("Erro ao criar o médico");

            return ResultViewModel<int>.Sucess(doctor.Id);
        }
    }
}