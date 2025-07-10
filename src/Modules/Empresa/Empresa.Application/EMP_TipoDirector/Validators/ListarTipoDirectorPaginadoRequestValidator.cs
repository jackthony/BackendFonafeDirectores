/*****
 * Nombre del archivo:  ListarTipoDirectorPaginadoRequestValidator.cs
 * Descripción:         Validador para la solicitud paginada de tipos de director. Hereda de AbstractValidator
 *                      y define las reglas de validación para el DTO ListarTipoDirectorPaginadoRequest.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using FluentValidation;
using Empresa.Application.TipoDirector.Dtos;

namespace Empresa.Application.TipoDirector.Validators
{
    public class ListarTipoDirectorPaginadoRequestValidator : AbstractValidator<ListarTipoDirectorPaginadoRequest>
    {
        public ListarTipoDirectorPaginadoRequestValidator()
        {
        }
    }
}
