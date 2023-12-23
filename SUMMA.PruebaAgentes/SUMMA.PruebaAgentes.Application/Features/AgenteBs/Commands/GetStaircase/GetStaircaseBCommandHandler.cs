using MediatR;
using SUMMA.PruebaAgentes.Application.Exceptions;
using SUMMA.PruebaAgentes.Domain;

namespace SUMMA.PruebaAgentes.Application.Features.AgenteBs.Commands.GetStaircase
{
    public class GetStaircaseBCommandHandler : IRequestHandler<GetStaircaseBCommand, string>
    {
        private AgenteB b;

        public GetStaircaseBCommandHandler()
        {
            b = new AgenteB();
        }
        public Task<string> Handle(GetStaircaseBCommand request, CancellationToken cancellationToken)
        {
            if (request.Number < 0 || request.Number > 99)
            {
                throw new BadRequestException("el valor ingresado debe ser mayor a 0 y menor a 100");
            }
            return Task.FromResult(b.GetStaircase(request.Number));
        }
    }
}
