/*****
 * Nombre del archivo:  ListarCargoPaginadoRequestValidator.cs
 * Descripción:         Clase que valida las solicitudes de listado paginado de cargos (`ListarCargoPaginadoRequest`) utilizando FluentValidation. 
 *                      Incluye reglas de validación para `Page` y `PageSize` (deben ser mayores que cero) y para `Nombre` (opcional, pero no debe exceder los 200 caracteres).
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using FluentValidation;
using Empresa.Application.Cargo.Dtos;

namespace Empresa.Application.Cargo.Validators
{
    public class ListarCargoPaginadoRequestValidator : AbstractValidator<ListarCargoPaginadoRequest>
    {
        public ListarCargoPaginadoRequestValidator()
        {
            // Page y PageSize deben ser > 0
            RuleFor(x => x.Page)
                .GreaterThan(0)
                .WithMessage("El número de página debe ser mayor que cero.");
            RuleFor(x => x.PageSize)
                .GreaterThan(0)
                .WithMessage("El tamaño de página debe ser mayor que cero.");

            // Nombre opcional, pero si se envía no puede exceder 200 caracteres
            When(x => !string.IsNullOrEmpty(x.Nombre), () =>
            {
                RuleFor(x => x.Nombre!)
                    .MaximumLength(200)
                    .WithMessage("El nombre no debe superar los 200 caracteres.");
            });

            // Estado es opcional y debe ser true o false (no se requiere validación adicional)
        }
    }
}
