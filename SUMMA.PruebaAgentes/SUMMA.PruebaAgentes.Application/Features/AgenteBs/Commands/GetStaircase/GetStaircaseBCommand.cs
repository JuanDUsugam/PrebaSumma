using MediatR;
using SUMMA.PruebaAgentes.Application.Exceptions;

namespace SUMMA.PruebaAgentes.Application.Features.AgenteBs.Commands.GetStaircase
{
    public class GetStaircaseBCommand : IRequest<string>
    {
        public int Number { get; set; }

    }
}
