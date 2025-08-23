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
            var specialities = await _unitOfWork.Specialties.GetAllAsync();

            if (specialities == null || !specialities.Any())
            {
                return ResultViewModel<List<SpecialtyViewModel>>.Error("No specialties found.");
            }

            var specialtyViewModels = specialities.Select(s => new SpecialtyViewModel
            {
                Id = s.Id,
                Name = s.Name,
                Description = s.Description,
                CreatedAt = s.CreatedAt
            }).ToList();

            return ResultViewModel<List<SpecialtyViewModel>>.Sucess(specialtyViewModels);
        }
    }
}
