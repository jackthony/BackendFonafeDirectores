using Rol.Application.Dtos;
using FluentValidation;

namespace Rol.Application.Validators
{
    public class CrearRolRequestValidator : AbstractValidator<CrearRolRequest>
    {
        public CrearRolRequestValidator()
        {
        }
    }
}
