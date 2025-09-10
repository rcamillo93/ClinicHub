using ClinicHub.Application.Commands.PricingCommands.Create;
using ClinicHub.Application.Queries.PricingQueries.GetAll;
using ClinicHub.Application.Queries.PricingQueries.GetById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PricingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PricingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post(CreatePricingCommand command)
        {
            var result = await _mediator.Send(command);

            if (!result.IsSuccess)
                return BadRequest(result);

            return CreatedAtAction(nameof(GetById), new {id = result.Data});
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAll([FromQuery] int? healthInsuranceId, [FromQuery] int? specialtyId,
                                             [FromQuery] int? consultationTypeId)
        {
            var query = new GetAllPricingQuery
            {
                HealthInsuranceId = healthInsuranceId,
                SpecialtyId = specialtyId,
                ConsultationTypeId = consultationTypeId
            };

            var result = await _mediator.Send(query);

            if (!result.IsSuccess)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _mediator.Send(new GetPricingByIdQuery(id));

            if (!result.IsSuccess)
                return BadRequest(result);

            return Ok(result);
        }
    }
}