using FluentValidation;
using Usuario.Application.User.Dtos;

namespace Usuario.Application.User.Validators
{
    public class EliminarUserRequestValidator : AbstractValidator<EliminarUserRequest>
    {
        public EliminarUserRequestValidator()
        {
        }
    }
}
