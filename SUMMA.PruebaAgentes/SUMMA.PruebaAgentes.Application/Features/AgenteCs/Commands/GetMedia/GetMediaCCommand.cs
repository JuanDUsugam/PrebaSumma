using MediatR;
using SUMMA.PruebaAgentes.Application.Exceptions;

namespace SUMMA.PruebaAgentes.Application.Features.AgenteCs.Commands.GetMedia
{
    public class GetMediaCCommand : IRequest<double>
    {
        public List<double> ListReals { get; set; }
    }
}
