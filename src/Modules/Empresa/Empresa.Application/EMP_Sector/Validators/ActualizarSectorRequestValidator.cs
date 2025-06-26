using FluentValidation;
using Empresa.Application.Sector.Dtos;

namespace Empresa.Application.Sector.Validators
{
    public class ActualizarSectorRequestValidator : AbstractValidator<ActualizarSectorRequest>
    {
        public ActualizarSectorRequestValidator()
        {
        }
    }
}
