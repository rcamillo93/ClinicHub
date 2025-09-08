using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using ClinicHub.Core.Repositores;
using MediatR;

namespace ClinicHub.Application.Queries.SpecialtyByIdQueries.GetById
{
    public class GetSpecialtyByIdHandler : IRequestHandler<GetSpecialtyByIdQuery, ResultViewModel<SpecialtyViewModel>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetSpecialtyByIdHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultViewModel<SpecialtyViewModel>> Handle(GetSpecialtyByIdQuery request, CancellationToken cancellationToken)
        {
            var specialty = await _unitOfWork.Specialties.GetByIdAsync(request.Id);

            if (specialty == null)
            {
                return ResultViewModel<SpecialtyViewModel>.Error("Specialty not found.");
            }

            var viewModel = new SpecialtyViewModel(specialty.Id, specialty.Name, specialty.Description, specialty.CreatedAt);

            return ResultViewModel<SpecialtyViewModel>.Success(viewModel);
        }
    }   
}
