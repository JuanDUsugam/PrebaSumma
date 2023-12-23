using MediatR;
using SUMMA.PruebaAgentes.Application.Exceptions;
using SUMMA.PruebaAgentes.Domain;

namespace SUMMA.PruebaAgentes.Application.Features.AgenteCs.Commands.GetStaircase
{
    public class GetStaircaseCCommandHandler : IRequestHandler<GetStaircaseCCommand, string>
    {
        private AgenteC c;

        public GetStaircaseCCommandHandler()
        {
            c = new AgenteC();
        }
        public Task<string> Handle(GetStaircaseCCommand request, CancellationToken cancellationToken)
        {
            if (request.Number < 0 || request.Number > 99)
            {
                throw new BadRequestException("el valor ingresado debe ser mayor a 0 y menor a 100");
            }
            return Task.FromResult(c.GetStaircase(request.Number));
        }
    }
}
