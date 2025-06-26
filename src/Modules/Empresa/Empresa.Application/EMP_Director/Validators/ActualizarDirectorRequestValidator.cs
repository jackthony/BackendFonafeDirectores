using FluentValidation;
using Empresa.Application.Director.Dtos;
using System;

namespace Empresa.Application.Director.Validators
{
    public class ActualizarDirectorRequestValidator
        : AbstractValidator<ActualizarDirectorRequest>
    {
        public ActualizarDirectorRequestValidator()
        {
            // 1. ID del director
            RuleFor(x => x.nIdRegistro)
                .GreaterThan(0)
                .WithMessage("El identificador del director es obligatorio y debe ser mayor que cero.");

            // 2. Empresa (FK NOT NULL)
            RuleFor(x => x.nIdEmpresa)
                .GreaterThan(0)
                .WithMessage("Debe especificar una empresa válida.");

        }
    }
}
