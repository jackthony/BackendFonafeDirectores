using FluentValidation;
using Usuario.Application.Modulo.Dtos;

namespace Usuario.Application.Modulo.Validators
{
    public class EliminarModuloRequestValidator : AbstractValidator<EliminarModuloRequest>
    {
        public EliminarModuloRequestValidator()
        {
        }
    }
}
