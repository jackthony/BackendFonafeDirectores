/*****
 * Nombre del archivo:  ActualizarTipoDirectorRequestValidator.cs
 * Descripción:         Validador para la solicitud de actualización de tipo de director. Hereda de AbstractValidator
 *                      y define las reglas de validación para el DTO ActualizarTipoDirectorRequest.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using FluentValidation;
using Empresa.Application.TipoDirector.Dtos;

namespace Empresa.Application.TipoDirector.Validators
{
    public class ActualizarTipoDirectorRequestValidator : AbstractValidator<ActualizarTipoDirectorRequest>
    {
        public ActualizarTipoDirectorRequestValidator()
        {
        }
    }
}
