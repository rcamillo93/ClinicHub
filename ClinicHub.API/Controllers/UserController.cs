using ClinicHub.Application.Commands.DoctorCommands.Create;
using ClinicHub.Application.Commands.DoctorCommands.Update;
using ClinicHub.Application.Commands.UserCommands.Create;
using ClinicHub.Application.Commands.UserCommands.Update;
using ClinicHub.Application.Queries.DoctorQueries.GetAll;
using ClinicHub.Application.Queries.DoctorQueries.GetById;
using ClinicHub.Application.Queries.UserQueries.GetAll;
using ClinicHub.Application.Queries.UserQueries.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ClinicHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand command)
        {
            var result = await _mediator.Send(command);

            if (!result.IsSuccess)
                return BadRequest(result);

            return CreatedAtAction(nameof(GetUser), new { id = result.Data });
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetUsers()
        {
            var result = await _mediator.Send(new GetAllUsersQuery());

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetUser(int id)
        {
            var result = await _mediator.Send(new GetUserByIdQuery(id));

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPut("user/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] UpdateUserCommand command)
        {
            if (id != command.Id)
                return BadRequest("Id não confere com o do usuário");

            var result = await _mediator.Send(command);

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }


        [HttpPost("doctor")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateDoctor([FromBody] CreateDoctorCommand command)
        {
            var result = await _mediator.Send(command);

            if (result.IsSuccess)
                return BadRequest(result);
            
            return CreatedAtAction(nameof(GetDoctor), new { id = result.Data });
        }

        [HttpGet("doctors")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetDoctors()
        {
            var result = await _mediator.Send(new GetAllDoctorsQuery());

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("doctor/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetDoctor(int id)
        {
            var result = await _mediator.Send(new GetDoctorByIdQuery(id));

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPut("doctor/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateDoctor(int id, [FromBody] UpdateDoctorCommand command)
        {
            if (id != command.Id)
                return BadRequest("Id não confere com o do médico");

            var result = await _mediator.Send(command);

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }
    }
}