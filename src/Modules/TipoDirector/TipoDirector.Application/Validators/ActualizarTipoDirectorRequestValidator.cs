using TipoDirector.Application.Dtos;
using FluentValidation;

namespace TipoDirector.Application.Validators
{
    public class ActualizarTipoDirectorRequestValidator : AbstractValidator<ActualizarTipoDirectorRequest>
    {
        public ActualizarTipoDirectorRequestValidator()
        {
        }
    }
}
