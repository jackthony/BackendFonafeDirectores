using FluentValidation;
using Usuario.Application.User.Dtos;

namespace Usuario.Application.User.Validators
{
    public class ListarUserRequestValidator : AbstractValidator<ListarUserRequest>
    {
        public ListarUserRequestValidator()
        {
        }
    }
}
