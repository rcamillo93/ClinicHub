using ClinicHub.Application.Models;
using MediatR;

namespace ClinicHub.Application.Commands.User.Create
{
    public class CreateUser : IRequest<ResultViewModel<int>>
    {

    }
}
