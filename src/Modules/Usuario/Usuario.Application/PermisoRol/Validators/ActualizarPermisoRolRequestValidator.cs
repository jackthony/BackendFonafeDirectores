using FluentValidation;
using Usuario.Application.PermisoRol.Dtos;

namespace Usuario.Application.PermisoRol.Validators
{
    public class ActualizarPermisoRolRequestValidator : AbstractValidator<ActualizarPermisoRolRequest>
    {
        public ActualizarPermisoRolRequestValidator()
        {
        }
    }
}
