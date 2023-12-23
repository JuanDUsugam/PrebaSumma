using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SUMMA.PruebaAgentes.Application.Features.AgenteAs.Commands.GetMedia;
using SUMMA.PruebaAgentes.Application.Features.AgenteAs.Commands.GetStaircase;

namespace SUMMA.PruebaAgentes.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgenteAController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AgenteAController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<double>> GetMedia([FromBody] GetMediaCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpGet]
        public async Task<ActionResult<string>> GetStaircase([FromQuery] GetStaircaseCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
