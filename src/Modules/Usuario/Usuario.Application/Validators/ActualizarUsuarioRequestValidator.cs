using Usuario.Application.Dtos;
using FluentValidation;

namespace Usuario.Application.Validators
{
    public class ActualizarUsuarioRequestValidator : AbstractValidator<ActualizarUsuarioRequest>
    {
        public ActualizarUsuarioRequestValidator()
        {
        }
    }
}
