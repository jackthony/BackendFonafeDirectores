/*****
 * Nombre de clase:     ListarEspecialidadRequestValidator
 * Descripción:         Clase validadora para el DTO ListarEspecialidadRequest, utilizada para
 *                      definir reglas de validación previas al listado simple de especialidades.
 *                      Actualmente no contiene reglas definidas.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase generada como base para futuras reglas de validación del listado de especialidades.
 *****/

using FluentValidation;
using Empresa.Application.Especialidad.Dtos;

namespace Empresa.Application.Especialidad.Validators
{
    public class ListarEspecialidadRequestValidator : AbstractValidator<ListarEspecialidadRequest>
    {
        public ListarEspecialidadRequestValidator()
        {
        }
    }
}
