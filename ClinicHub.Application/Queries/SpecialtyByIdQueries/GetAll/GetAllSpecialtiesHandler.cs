using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using ClinicHub.Core.Repositores;
using MediatR;

namespace ClinicHub.Application.Queries.SpecialtyByIdQueries.GetAll
{
    public class GetAllSpecialtiesHandler : IRequestHandler<GetAllSpecialtiesQuery, ResultViewModel<List<SpecialtyViewModel>>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllSpecialtiesHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ResultViewModel<List<SpecialtyViewModel>>> Handle(GetAllSpecialtiesQuery request, CancellationToken cancellationToken)
        {
            var specialities = await _unitOfWork.Specialties.GetAllAsync(request.Name);

            var specialtyViewModels = specialities.Select(s => new SpecialtyViewModel(
                s.Id,
                s.Name,
                s.Description,
                s.CreatedAt
            )).ToList();

            return ResultViewModel<List<SpecialtyViewModel>>.Success(specialtyViewModels);
        }
    }
}