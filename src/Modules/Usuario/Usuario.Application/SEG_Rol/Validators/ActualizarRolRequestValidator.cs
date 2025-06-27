using FluentValidation;
using Usuario.Application.Rol.Dtos;

namespace Usuario.Application.Rol.Validators
{
    public class ActualizarRolRequestValidator : AbstractValidator<ActualizarRolRequest>
    {
        public ActualizarRolRequestValidator()
        {
        }
    }
}
