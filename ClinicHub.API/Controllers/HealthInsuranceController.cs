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
    }
}
