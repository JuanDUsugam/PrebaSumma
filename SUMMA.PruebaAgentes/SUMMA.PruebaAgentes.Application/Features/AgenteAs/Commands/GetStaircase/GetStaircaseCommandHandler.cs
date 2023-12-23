using MediatR;
using SUMMA.PruebaAgentes.Application.Exceptions;
using SUMMA.PruebaAgentes.Domain;

namespace SUMMA.PruebaAgentes.Application.Features.AgenteAs.Commands.GetStaircase
{
    public class GetStaircaseCommandHandler : IRequestHandler<GetStaircaseCommand, string>
    {
        private AgenteA a;

        public GetStaircaseCommandHandler()
        {
            this.a = new AgenteA();
        }

        public Task<string> Handle(GetStaircaseCommand request, CancellationToken cancellationToken)
        {
            if (request.Number < 0 || request.Number > 99)
            {
                throw new BadRequestException("el valor ingresado debe ser mayor a 0 y menor a 100");
            }
            return Task.FromResult(a.GetStaircase(request.Number));
        }
    }
}
