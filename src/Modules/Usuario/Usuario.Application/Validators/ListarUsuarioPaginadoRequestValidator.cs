using Usuario.Application.Dtos;
using FluentValidation;

namespace Usuario.Application.Validators
{
    public class ListarUsuarioPaginadoRequestValidator : AbstractValidator<ListarUsuarioPaginadoRequest>
    {
        public ListarUsuarioPaginadoRequestValidator()
        {
        }
    }
}
