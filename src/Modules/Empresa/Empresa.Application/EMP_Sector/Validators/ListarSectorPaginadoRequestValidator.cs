/*****
 * Nombre del archivo:  ListarSectorPaginadoRequestValidator.cs
 * Descripción:         Validador para la solicitud paginada de sectores. Hereda de AbstractValidator
 *                      y define las reglas de validación para el DTO ListarSectorPaginadoRequest.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using FluentValidation;
using Empresa.Application.Sector.Dtos;

namespace Empresa.Application.Sector.Validators
{
    public class ListarSectorPaginadoRequestValidator : AbstractValidator<ListarSectorPaginadoRequest>
    {
        public ListarSectorPaginadoRequestValidator()
        {
        }
    }
}
