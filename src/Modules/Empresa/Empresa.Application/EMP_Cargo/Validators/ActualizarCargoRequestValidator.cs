using FluentValidation;
using Empresa.Application.Cargo.Dtos;

namespace Empresa.Application.Cargo.Validators
{
    public class ActualizarCargoRequestValidator : AbstractValidator<ActualizarCargoRequest>
    {
        public ActualizarCargoRequestValidator()
        {
        }
    }
}
