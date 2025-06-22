using FluentValidation;
using Empresa.Application.Cargo.Dtos;

namespace Empresa.Application.Cargo.Validators
{
    public class EliminarCargoRequestValidator : AbstractValidator<EliminarCargoRequest>
    {
        public EliminarCargoRequestValidator()
        {
        }
    }
}
