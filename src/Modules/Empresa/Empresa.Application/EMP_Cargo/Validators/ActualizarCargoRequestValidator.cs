using Empresa.Application.EMP_Cargo.Dtos;
using FluentValidation;

namespace Empresa.Application.EMP_Cargo.Validators
{
    public class ActualizarCargoRequestValidator : AbstractValidator<ActualizarCargoRequest>
    {
        public ActualizarCargoRequestValidator()
        {
        }
    }
}
