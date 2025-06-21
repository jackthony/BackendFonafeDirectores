using TipoDirector.Application.Dtos;
using FluentValidation;

namespace TipoDirector.Application.Validators
{
    public class CrearTipoDirectorRequestValidator : AbstractValidator<CrearTipoDirectorRequest>
    {
        public CrearTipoDirectorRequestValidator()
        {
        }
    }
}
