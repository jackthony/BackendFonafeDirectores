/*****
 * Nombre del archivo:  CrearCargoRequestValidator.cs
 * Descripción:         Clase que valida las solicitudes de creación de cargo (`CrearCargoRequest`) utilizando FluentValidation. 
 *                      Incluye reglas de validación para el `sNombreCargo` y `nUsuarioRegistro`, asegurando que el nombre del cargo sea obligatorio y no exceda los 200 caracteres,
 *                      y que el ID del usuario que registra sea válido (mayor que cero).
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using FluentValidation;
using Empresa.Application.Cargo.Dtos;

namespace Empresa.Application.Cargo.Validators
{
    public class CrearCargoRequestValidator : AbstractValidator<CrearCargoRequest>
    {
        public CrearCargoRequestValidator()
        {
            // El nombre del cargo es obligatorio y no puede exceder 200 caracteres
            RuleFor(x => x.sNombreCargo)
                .NotEmpty()
                .WithMessage("El nombre del cargo es obligatorio.")
                .MaximumLength(200)
                .WithMessage("El nombre del cargo no debe superar los 200 caracteres.");

            // El usuario que registra debe existir (ID > 0)
            RuleFor(x => x.nUsuarioRegistro)
                .GreaterThan(0)
                .WithMessage("El ID del usuario que registra debe ser mayor que cero.");
        }
    }
}
