using FluentValidation;
using Usuario.Application.PermisoRol.Dtos;

namespace Usuario.Application.PermisoRol.Validators
{
    public class EliminarPermisoRolRequestValidator : AbstractValidator<EliminarPermisoRolRequest>
    {
        public EliminarPermisoRolRequestValidator()
        {
        }
    }
}
