using MediatR;
using SUMMA.PruebaAgentes.Domain;

namespace SUMMA.PruebaAgentes.Application.Features.AgenteAs.Commands.GetMedia
{
    public class GetMediaCommandHandler : IRequestHandler<GetMediaCommand, double>
    {
        private AgenteA a;
        public GetMediaCommandHandler()
        {
            a = new AgenteA();
        }
        public Task<double> Handle(GetMediaCommand request, CancellationToken cancellationToken)
        {
            if (request.ListReals == null || !request.ListReals.Any())
            {
                throw new BadImageFormatException("La lista requerida no puede ser nula ni estar vacia.");
            }
            return Task.FromResult(a.GetMedia(request.ListReals));
        }
    }
}
