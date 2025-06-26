using FluentValidation;
using Usuario.Application.PermisoRol.Dtos;

namespace Usuario.Application.PermisoRol.Validators
{
    public class CrearPermisoRolRequestValidator : AbstractValidator<CrearPermisoRolRequest>
    {
        public CrearPermisoRolRequestValidator()
        {
        }
    }
}
