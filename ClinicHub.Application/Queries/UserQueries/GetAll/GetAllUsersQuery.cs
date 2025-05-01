using ClinicHub.Application.Models;
using ClinicHub.Application.ViewModel;
using MediatR;

namespace ClinicHub.Application.Queries.UserQueries.GetAll
{
    public class GetAllUsersQuery : IRequest<ResultViewModel<List<UserViewModel>>>
    {

    }
}