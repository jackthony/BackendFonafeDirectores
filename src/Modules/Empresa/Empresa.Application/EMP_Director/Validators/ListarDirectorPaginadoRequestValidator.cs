/*****
 * Nombre del archivo:  ListarDirectorPaginadoRequestValidator.cs
 * Descripción:         Validador para la solicitud de listado de directores paginado. Asegura que los parámetros de la paginación sean válidos, y valida el nombre, ID de empresa y estado si se proporcionan.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Validación agregada para el número de página, tamaño de página, nombre de director, ID de empresa y estado.
 *****/
using FluentValidation;
using Empresa.Application.Director.Dtos;

namespace Empresa.Application.Director.Validators
{
    public class ListarDirectorPaginadoRequestValidator
            : AbstractValidator<ListarDirectorPaginadoRequest>
    {
        public ListarDirectorPaginadoRequestValidator()
        {
            // Page y PageSize deben ser mayores que cero
            RuleFor(x => x.Page)
                .GreaterThan(0)
                .WithMessage("El número de página debe ser mayor que cero.");

            RuleFor(x => x.PageSize)
                .GreaterThan(0)
                .WithMessage("El tamaño de página debe ser mayor que cero.");

            // Nombre opcional: si se envía, no puede exceder 250 caracteres
            When(x => !string.IsNullOrEmpty(x.Nombre), () =>
            {
                RuleFor(x => x.Nombre!)
                    .MaximumLength(250)
                    .WithMessage("El nombre no puede exceder 250 caracteres.");
            });

            // Empresa opcional: si se envía, debe ser mayor que cero
            When(x => x.nIdEmpresa.HasValue, () =>
            {
                RuleFor(x => x.nIdEmpresa!.Value)
                    .GreaterThan(0)
                    .WithMessage("El ID de empresa debe ser mayor que cero.");
            });

            // Estado es bool? opcional, no requiere validación adicional
        }
    }
}
