using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using ClinicHub.Core.Repositores;
using MediatR;

namespace ClinicHub.Application.Queries.DoctorQueries.GetAll
{
    public class GetAllDoctorsHandler : IRequestHandler<GetAllDoctorsQuery, ResultViewModel<List<DoctorViewModel>>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllDoctorsHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultViewModel<List<DoctorViewModel>>> Handle(GetAllDoctorsQuery request, CancellationToken cancellationToken)
        {
            var doctors = await _unitOfWork.Doctors.GetAllAsync(request.Name);
          
            var viewModel = doctors.Select(d => new DoctorViewModel().FromEntity(d));

            return ResultViewModel<List<DoctorViewModel>>.Success(viewModel.ToList());
        }
    }
}