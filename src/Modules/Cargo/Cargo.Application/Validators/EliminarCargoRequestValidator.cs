using Cargo.Application.Dtos;
using FluentValidation;

namespace Cargo.Application.Validators
{
    public class EliminarCargoRequestValidator : AbstractValidator<EliminarCargoRequest>
    {
        public EliminarCargoRequestValidator()
        {
        }
    }
}
