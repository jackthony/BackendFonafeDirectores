using FluentValidation;
using Empresa.Application.TipoDirector.Dtos;

namespace Empresa.Application.TipoDirector.Validators
{
    public class ActualizarTipoDirectorRequestValidator : AbstractValidator<ActualizarTipoDirectorRequest>
    {
        public ActualizarTipoDirectorRequestValidator()
        {
        }
    }
}
