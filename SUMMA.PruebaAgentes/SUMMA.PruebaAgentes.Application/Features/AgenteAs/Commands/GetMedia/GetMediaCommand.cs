using MediatR;
using SUMMA.PruebaAgentes.Application.Exceptions;

namespace SUMMA.PruebaAgentes.Application.Features.AgenteAs.Commands.GetMedia
{
    public class GetMediaCommand : IRequest<double>
    {
        public List<double> ListReals { get; set; }
    }
}
