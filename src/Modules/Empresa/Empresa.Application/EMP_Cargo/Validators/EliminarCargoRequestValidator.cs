/*****
 * Nombre del archivo:  EliminarCargoRequestValidator.cs
 * Descripción:         Clase que valida las solicitudes de eliminación de cargo (`EliminarCargoRequest`) utilizando FluentValidation. 
 *                      Incluye reglas de validación para el `nIdCargo` (debe ser mayor que cero) y `nUsuarioModificacion` (el ID del usuario debe ser válido y mayor que cero).
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using FluentValidation;
using Empresa.Application.Cargo.Dtos;

namespace Empresa.Application.Cargo.Validators
{
    public class EliminarCargoRequestValidator : AbstractValidator<EliminarCargoRequest>
    {
        public EliminarCargoRequestValidator()
        {
            // El ID del cargo a eliminar debe ser mayor que cero
            RuleFor(x => x.nIdCargo)
                .GreaterThan(0)
                .WithMessage("El identificador del cargo es obligatorio y debe ser mayor que cero.");

            // El usuario que realiza la eliminación debe ser un ID válido
            RuleFor(x => x.nUsuarioModificacion)
                .GreaterThan(0)
                .WithMessage("El ID del usuario que modifica debe ser mayor que cero.");
        }
    }
}
