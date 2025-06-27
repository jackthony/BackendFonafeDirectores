using FluentValidation;
using Usuario.Application.Modulo.Dtos;

namespace Usuario.Application.Modulo.Validators
{
    public class ListarModuloRequestValidator : AbstractValidator<ListarModuloRequest>
    {
        public ListarModuloRequestValidator()
        {
        }
    }
}
