using Cargo.Application.Dtos;
using FluentValidation;

namespace Cargo.Application.Validators
{
    public class CrearCargoRequestValidator : AbstractValidator<CrearCargoRequest>
    {
        public CrearCargoRequestValidator()
        {
        }
    }
}
