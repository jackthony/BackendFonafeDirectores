/*****
 * Nombre del archivo:  ActualizarCargoRequestValidator.cs
 * Descripción:         Clase que valida las solicitudes de actualización de cargo (`ActualizarCargoRequest`) utilizando FluentValidation. 
 *                      Incluye reglas de validación para el `nIdCargo`, `sNombreCargo` y `nUsuarioModificacion`, asegurando que cumplan con los requisitos establecidos.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using FluentValidation;
using Empresa.Application.Cargo.Dtos;

namespace Empresa.Application.Cargo.Validators
{
    public class ActualizarCargoRequestValidator : AbstractValidator<ActualizarCargoRequest>
    {
        public ActualizarCargoRequestValidator()
        {
            // 1) nIdCargo: PK int NOT NULL
            RuleFor(x => x.nIdCargo)
                .GreaterThan(0)
                .WithMessage("El identificador del cargo es obligatorio y debe ser mayor que cero.");

            // 2) sNombreCargo: varchar(200) NOT NULL
            RuleFor(x => x.sNombreCargo)
                .NotEmpty()
                .WithMessage("El nombre del cargo es obligatorio.")
                .MaximumLength(200)
                .WithMessage("El nombre del cargo no puede exceder los 200 caracteres.");

            // 3) nUsuarioModificacion: FK int NOT NULL
            RuleFor(x => x.nUsuarioModificacion)
                .GreaterThan(0)
                .WithMessage("Debe especificar el usuario que realiza la modificación.");
        }
    }
}
