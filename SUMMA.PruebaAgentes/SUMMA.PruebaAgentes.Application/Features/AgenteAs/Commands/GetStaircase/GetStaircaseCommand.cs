using MediatR;

namespace SUMMA.PruebaAgentes.Application.Features.AgenteAs.Commands.GetStaircase
{
    public class GetStaircaseCommand : IRequest<string>
    {
        public int Number { get; set; }
    }
}
