using FluentValidation;
using Empresa.Application.Sector.Dtos;

namespace Empresa.Application.Sector.Validators
{
    public class CrearSectorRequestValidator : AbstractValidator<CrearSectorRequest>
    {
        public CrearSectorRequestValidator()
        {
        }
    }
}
