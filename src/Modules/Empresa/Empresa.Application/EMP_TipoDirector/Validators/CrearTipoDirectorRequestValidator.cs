using FluentValidation;
using Empresa.Application.TipoDirector.Dtos;

namespace Empresa.Application.TipoDirector.Validators
{
    public class CrearTipoDirectorRequestValidator : AbstractValidator<CrearTipoDirectorRequest>
    {
        public CrearTipoDirectorRequestValidator()
        {
        }
    }
}
