using FluentValidation;
using Usuario.Application.Rol.Dtos;

namespace Usuario.Application.Rol.Validators
{
    public class ListarRolPaginadoRequestValidator : AbstractValidator<ListarRolPaginadoRequest>
    {
        public ListarRolPaginadoRequestValidator()
        {
        }
    }
}
