using FluentValidation;
using Usuario.Application.Rol.Dtos;

namespace Usuario.Application.Rol.Validators
{
    public class CrearRolRequestValidator : AbstractValidator<CrearRolRequest>
    {
        public CrearRolRequestValidator()
        {
        }
    }
}
