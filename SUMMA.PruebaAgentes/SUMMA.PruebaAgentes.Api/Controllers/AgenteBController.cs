using MediatR;
using Microsoft.AspNetCore.Mvc;
using SUMMA.PruebaAgentes.Application.Features.AgenteBs.Commands.GetMedia;
using SUMMA.PruebaAgentes.Application.Features.AgenteBs.Commands.GetStaircase;

namespace SUMMA.PruebaAgentes.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgenteBController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AgenteBController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<double>> GetMedia([FromBody] GetMediaBCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpGet]
        public async Task<ActionResult<string>> GetStaircase([FromQuery] GetStaircaseBCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
