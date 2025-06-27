using FluentValidation;
using Usuario.Application.User.Dtos;

namespace Usuario.Application.User.Validators
{
    public class ListarUserPaginadoRequestValidator : AbstractValidator<ListarUserPaginadoRequest>
    {
        public ListarUserPaginadoRequestValidator()
        {
        }
    }
}
