using MediatR;
using SUMMA.PruebaAgentes.Application.Exceptions;

namespace SUMMA.PruebaAgentes.Application.Features.AgenteBs.Commands.GetMedia
{
    public class GetMediaBCommand : IRequest<double>
    {
        public List<double> ListReals { get; set; }
    }
}
