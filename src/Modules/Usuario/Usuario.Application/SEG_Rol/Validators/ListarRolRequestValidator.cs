using FluentValidation;
using Usuario.Application.Rol.Dtos;

namespace Usuario.Application.Rol.Validators
{
    public class ListarRolRequestValidator : AbstractValidator<ListarRolRequest>
    {
        public ListarRolRequestValidator()
        {
        }
    }
}
