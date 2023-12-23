using MediatR;
using SUMMA.PruebaAgentes.Domain;

namespace SUMMA.PruebaAgentes.Application.Features.AgenteBs.Commands.GetMedia
{
    public class GetMediaBCommandHandler : IRequestHandler<GetMediaBCommand, double>
    {
        private AgenteB b;
        public GetMediaBCommandHandler()
        {
            b = new AgenteB();
        }
        public Task<double> Handle(GetMediaBCommand request, CancellationToken cancellationToken)
        {
            if (request.ListReals == null || !request.ListReals.Any())
            {
                throw new BadImageFormatException("La lista requerida no puede ser nula ni estar vacia.");
            }
            return Task.FromResult(b.GetMedia(request.ListReals));
        }
    }
}
