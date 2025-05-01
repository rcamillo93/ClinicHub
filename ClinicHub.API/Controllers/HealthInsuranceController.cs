using ClinicHub.Application.Commands.HealthInsuranceCommands.Create;
using ClinicHub.Application.Commands.HealthInsuranceCommands.Delete;
using ClinicHub.Application.Commands.HealthInsuranceCommands.Update;
using ClinicHub.Application.Queries.HealthInsurancesQueries.GetAll;
using ClinicHub.Application.Queries.HealthInsurancesQueries.GetById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthInsuranceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HealthInsuranceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> CreateHealthInsurance([FromBody] CreateHealthInsuranceCommand command)
        {
            var result = await _mediator.Send(command);

            if (!result.IsSuccess)
                return BadRequest(result);

            return CreatedAtAction(nameof(GetHealthInsurance), new { id = result.Data });
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetHealthInsurances()
        {
            var result = await _mediator.Send(new GetAllHealthInsurancesQuery());

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetHealthInsurance(int id)
        {
            var result = await _mediator.Send(new GetHealthInsuranceByIdQuery(id));

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateHealthInsurance(int id, [FromBody] UpdateHealthInsuranceCommand command)
        {
            if (id != command.Id)
                return BadRequest("ID mismatch");

            var result = await _mediator.Send(command);

            if (!result.IsSuccess)
                return BadRequest(result);

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteHealthInsurance(int id)
        {
            var result = await _mediator.Send(new DeleteHealthInsuranceCommand(id));

            if (!result.IsSuccess)
                return BadRequest(result);

            return NoContent();

        }
    }
}