using FluentValidation;
using Empresa.Application.Cargo.Dtos;

namespace Empresa.Application.Cargo.Validators
{
    public class CrearCargoRequestValidator : AbstractValidator<CrearCargoRequest>
    {
        public CrearCargoRequestValidator()
        {
            RuleFor(x => x.NombreCargo)
                .NotEmpty().WithMessage("El nombre es obligatorio.")
                .MaximumLength(250).WithMessage("El nombre no debe superar los 250 caracteres.");

            RuleFor(x => x.UsuarioRegistroId)
                .GreaterThan(0).WithMessage("El ID del usuario que registra debe ser mayor que cero.");
        }
    }
}
