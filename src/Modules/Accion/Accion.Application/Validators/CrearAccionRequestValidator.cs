using Accion.Application.Dtos;
using FluentValidation;

namespace Accion.Application.Validators
{
    public class CrearAccionRequestValidator : AbstractValidator<CrearAccionRequest>
    {
        public CrearAccionRequestValidator()
        {
        }
    }
}
