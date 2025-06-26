using FluentValidation;
using Usuario.Application.PermisoRol.Dtos;

namespace Usuario.Application.PermisoRol.Validators
{
    public class ListarPermisoRolPaginadoRequestValidator : AbstractValidator<ListarPermisoRolPaginadoRequest>
    {
        public ListarPermisoRolPaginadoRequestValidator()
        {
        }
    }
}
