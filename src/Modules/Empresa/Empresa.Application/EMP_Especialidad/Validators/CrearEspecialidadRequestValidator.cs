/*****
 * Nombre de clase:     CrearEspecialidadRequestValidator
 * Descripción:         Clase validadora para el DTO CrearEspecialidadRequest, utilizada para
 *                      definir reglas de validación previas a la creación de una nueva especialidad.
 *                      Actualmente no contiene reglas definidas.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase generada como base para futuras reglas de validación en la creación de especialidades.
 *****/

using FluentValidation;
using Empresa.Application.Especialidad.Dtos;

namespace Empresa.Application.Especialidad.Validators
{
    public class CrearEspecialidadRequestValidator : AbstractValidator<CrearEspecialidadRequest>
    {
        public CrearEspecialidadRequestValidator()
        {
        }
    }
}
