using FluentValidation;
using Usuario.Application.Rol.Dtos;

namespace Usuario.Application.Rol.Validators
{
    public class EliminarRolRequestValidator : AbstractValidator<EliminarRolRequest>
    {
        public EliminarRolRequestValidator()
        {
        }
    }
}
