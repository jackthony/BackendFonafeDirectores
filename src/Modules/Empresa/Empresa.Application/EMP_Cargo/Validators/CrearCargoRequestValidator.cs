using FluentValidation;
using Empresa.Application.Cargo.Dtos;

namespace Empresa.Application.Cargo.Validators
{
    public class CrearCargoRequestValidator : AbstractValidator<CrearCargoRequest>
    {
        public CrearCargoRequestValidator()
        {
        }
    }
}
