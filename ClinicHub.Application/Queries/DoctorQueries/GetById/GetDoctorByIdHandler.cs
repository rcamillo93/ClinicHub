using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using ClinicHub.Core.Repositores;
using MediatR;

namespace ClinicHub.Application.Queries.DoctorQueries.GetById
{
    public class GetDoctorByIdHandler : IRequestHandler<GetDoctorByIdQuery, ResultViewModel<DoctorViewModel>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetDoctorByIdHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultViewModel<DoctorViewModel>> Handle(GetDoctorByIdQuery request, CancellationToken cancellationToken)
        {
            var doctor = await _unitOfWork.Doctors.GetDoctorByIdAsync(request.Id);

            if (doctor is null)
            {
                return ResultViewModel<DoctorViewModel>.Error("Doctor not found");
            }

            var viewModel = new DoctorViewModel().FromEntity(doctor);

            return ResultViewModel<DoctorViewModel>.Success(viewModel);
        }
    }
}
