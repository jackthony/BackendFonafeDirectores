using FluentValidation;
using Usuario.Application.Modulo.Dtos;

namespace Usuario.Application.Modulo.Validators
{
    public class CrearModuloRequestValidator : AbstractValidator<CrearModuloRequest>
    {
        public CrearModuloRequestValidator()
        {
        }
    }
}
