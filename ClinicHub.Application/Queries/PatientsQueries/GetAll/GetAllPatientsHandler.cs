using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using ClinicHub.Core.Repositores;
using MediatR;

namespace ClinicHub.Application.Queries.PatientsQueries.GetAll
{
    public class GetAllPatientsHandler : IRequestHandler<GetAllPatientsQuery, ResultViewModel<List<PatientViewModel>>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllPatientsHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultViewModel<List<PatientViewModel>>> Handle(GetAllPatientsQuery request, CancellationToken cancellationToken)
        {
            var patients = await _unitOfWork.Patients.GetAllAsync(request.Name);

            var patientViewModels = patients.Select(p => new PatientViewModel().FromEntity(p));

            return ResultViewModel<List<PatientViewModel>>.Success(patientViewModels.ToList());
        }
    }
}
