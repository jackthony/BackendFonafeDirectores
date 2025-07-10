/*****
 * Nombre de clase:     CrearMinisterioRequestValidator
 * Descripción:         Clase validadora para el DTO CrearMinisterioRequest, utilizada para
 *                      aplicar reglas de validación antes de ejecutar el caso de uso de creación.
 *                      Actualmente no contiene reglas definidas.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase generada como base para futuras reglas de validación de creación de ministerios.
 *****/

using FluentValidation;
using Empresa.Application.Ministerio.Dtos;

namespace Empresa.Application.Ministerio.Validators
{
    public class CrearMinisterioRequestValidator : AbstractValidator<CrearMinisterioRequest>
    {
        public CrearMinisterioRequestValidator()
        {
        }
    }
}
