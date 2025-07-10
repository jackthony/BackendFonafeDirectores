/*****
 * Nombre de clase:     EliminarEspecialidadRequestValidator
 * Descripción:         Clase validadora para el DTO EliminarEspecialidadRequest, utilizada para
 *                      definir reglas de validación previas a la operación de eliminación de especialidades.
 *                      Actualmente no contiene reglas definidas.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase generada como base para futuras reglas de validación en la eliminación de especialidades.
 *****/

using FluentValidation;
using Empresa.Application.Especialidad.Dtos;

namespace Empresa.Application.Especialidad.Validators
{
    public class EliminarEspecialidadRequestValidator : AbstractValidator<EliminarEspecialidadRequest>
    {
        public EliminarEspecialidadRequestValidator()
        {
        }
    }
}
