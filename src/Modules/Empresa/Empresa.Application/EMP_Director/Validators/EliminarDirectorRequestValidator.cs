using FluentValidation;
using Empresa.Application.Director.Dtos;
using System;

namespace Empresa.Application.Director.Validators
{
    public class EliminarDirectorRequestValidator : AbstractValidator<EliminarDirectorRequest>
    {
        public EliminarDirectorRequestValidator()
        {
            // 1. El ID del director debe ser mayor que cero
            RuleFor(x => x.nDirectorId)
                .GreaterThan(0)
                .WithMessage("El identificador del director es obligatorio y debe ser mayor que cero.");

            // 2. El usuario que realiza la modificación debe ser un ID válido
            RuleFor(x => x.nUsuarioModificacionId)
                .GreaterThan(0)
                .WithMessage("El identificador del usuario de modificación debe ser mayor que cero.");

            // 3. La fecha de modificación es obligatoria y no puede ser futura
            RuleFor(x => x.dtFechaModificacion)
                .NotEmpty()
                .WithMessage("La fecha de modificación es obligatoria.")
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("La fecha de modificación no puede ser una fecha futura.");
        }
    }
}
