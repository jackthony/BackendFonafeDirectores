using FluentValidation;
using Usuario.Application.PermisoRol.Dtos;

namespace Usuario.Application.PermisoRol.Validators
{
    public class ListarPermisoRolRequestValidator : AbstractValidator<ListarPermisoRolRequest>
    {
        public ListarPermisoRolRequestValidator()
        {
        }
    }
}
