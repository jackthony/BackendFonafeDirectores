using FluentValidation;
using Usuario.Application.User.Dtos;

namespace Usuario.Application.User.Validators
{
    public class CrearUserRequestValidator : AbstractValidator<CrearUserRequest>
    {
        public CrearUserRequestValidator()
        {
        }
    }
}
