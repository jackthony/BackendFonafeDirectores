using Cargo.Application.Dtos;
using FluentValidation;

namespace Cargo.Application.Validators
{
    public class ActualizarCargoRequestValidator : AbstractValidator<ActualizarCargoRequest>
    {
        public ActualizarCargoRequestValidator()
        {
        }
    }
}
