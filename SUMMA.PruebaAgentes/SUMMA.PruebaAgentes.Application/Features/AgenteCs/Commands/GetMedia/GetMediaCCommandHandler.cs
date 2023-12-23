using MediatR;
using SUMMA.PruebaAgentes.Domain;

namespace SUMMA.PruebaAgentes.Application.Features.AgenteCs.Commands.GetMedia
{
    public class GetMediaCCommandHandler : IRequestHandler<GetMediaCCommand, double>
    {
        private AgenteC c;
        public GetMediaCCommandHandler()
        {
            c = new AgenteC();
        }
        public Task<double> Handle(GetMediaCCommand request, CancellationToken cancellationToken)
        {
            if (request.ListReals == null || !request.ListReals.Any())
            {
                throw new BadImageFormatException("La lista requerida no puede ser nula ni estar vacia.");
            }
            return Task.FromResult(c.GetMedia(request.ListReals));
        }
    }
}
