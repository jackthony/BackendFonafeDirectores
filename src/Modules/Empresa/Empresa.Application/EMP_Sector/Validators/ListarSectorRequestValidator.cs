/*****
 * Nombre del archivo:  ListarSectorRequestValidator.cs
 * Descripción:         Validador para la solicitud de listado de sectores. Hereda de AbstractValidator
 *                      y define las reglas de validación para el DTO ListarSectorRequest.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using FluentValidation;
using Empresa.Application.Sector.Dtos;

namespace Empresa.Application.Sector.Validators
{
    public class ListarSectorRequestValidator : AbstractValidator<ListarSectorRequest>
    {
        public ListarSectorRequestValidator()
        {
        }
    }
}
