using MediatR;
using SUMMA.PruebaAgentes.Application.Exceptions;

namespace SUMMA.PruebaAgentes.Application.Features.AgenteCs.Commands.GetStaircase
{
    public class GetStaircaseCCommand : IRequest<string>
    {
        public int Number { get; set; }
        
    }
}
