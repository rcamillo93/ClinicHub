using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using ClinicHub.Core.Repositores;
using MediatR;

namespace ClinicHub.Application.Queries.PatientsQueries.GetById
{
    public class GetPatientByIdHandler : IRequestHandler<GetPatientByIdQuery, ResultViewModel<PatientViewModel>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetPatientByIdHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultViewModel<PatientViewModel>> Handle(GetPatientByIdQuery request, CancellationToken cancellationToken)
        {
            var patient = await _unitOfWork.Patients.GetPatientByIdAsync(request.Id);

            if (patient == null)
            {
                return ResultViewModel<PatientViewModel>.Error("Patient not found.");
            }

            var viewModel = new PatientViewModel().FromEntity(patient);

            return ResultViewModel<PatientViewModel>.Success(viewModel);
        }
    }
}