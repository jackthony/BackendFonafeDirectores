/*****
 * Nombre de clase:     ActualizarEspecialidadRequestValidator
 * Descripción:         Clase validadora para el DTO ActualizarEspecialidadRequest, utilizada para
 *                      definir reglas de validación previas a la actualización de una especialidad existente.
 *                      Actualmente no contiene reglas definidas.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase generada como base para futuras reglas de validación en la actualización de especialidades.
 *****/

using FluentValidation;
using Empresa.Application.Especialidad.Dtos;

namespace Empresa.Application.Especialidad.Validators
{
    public class ActualizarEspecialidadRequestValidator : AbstractValidator<ActualizarEspecialidadRequest>
    {
        public ActualizarEspecialidadRequestValidator()
        {
        }
    }
}
