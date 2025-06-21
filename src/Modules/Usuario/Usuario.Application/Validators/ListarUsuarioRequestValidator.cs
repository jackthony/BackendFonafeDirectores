using Usuario.Application.Dtos;
using FluentValidation;

namespace Usuario.Application.Validators
{
    public class ListarUsuarioRequestValidator : AbstractValidator<ListarUsuarioRequest>
    {
        public ListarUsuarioRequestValidator()
        {
        }
    }
}
