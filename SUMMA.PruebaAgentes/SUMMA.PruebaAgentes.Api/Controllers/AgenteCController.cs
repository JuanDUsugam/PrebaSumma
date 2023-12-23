using MediatR;
using Microsoft.AspNetCore.Mvc;
using SUMMA.PruebaAgentes.Application.Features.AgenteCs.Commands.GetMedia;
using SUMMA.PruebaAgentes.Application.Features.AgenteCs.Commands.GetStaircase;

namespace SUMMA.PruebaAgentes.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgenteCController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AgenteCController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<double>> GetMedia([FromBody] GetMediaCCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpGet]
        public async Task<ActionResult<string>> GetStaircase([FromQuery] GetStaircaseCCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
