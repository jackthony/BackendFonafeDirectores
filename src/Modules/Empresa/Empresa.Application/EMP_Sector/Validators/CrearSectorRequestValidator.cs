using Empresa.Application.EMP_Sector.Dtos;
using FluentValidation;

namespace Empresa.Application.EMP_Sector.Validators
{
    public class CrearSectorRequestValidator : AbstractValidator<CrearSectorRequest>
    {
        public CrearSectorRequestValidator()
        {
        }
    }
}
