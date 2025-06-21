using Rol.Application.Dtos;
using FluentValidation;

namespace Rol.Application.Validators
{
    public class ListarRolPaginadoRequestValidator : AbstractValidator<ListarRolPaginadoRequest>
    {
        public ListarRolPaginadoRequestValidator()
        {
        }
    }
}
