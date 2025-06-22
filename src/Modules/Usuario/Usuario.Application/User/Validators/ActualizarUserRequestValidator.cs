using FluentValidation;
using Usuario.Application.User.Dtos;

namespace Usuario.Application.User.Validators
{
    public class ActualizarUserRequestValidator : AbstractValidator<ActualizarUserRequest>
    {
        public ActualizarUserRequestValidator()
        {
        }
    }
}
