/*****
 * Nombre de clase:     EliminarRubroRequestValidator
 * Descripción:         Validador para la clase EliminarRubroRequest.
 *                      Define las reglas de validación para la solicitud de
 *                      eliminación de un rubro.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase base del validador sin reglas definidas aún.
 *****/

using FluentValidation;
using Empresa.Application.Rubro.Dtos;

namespace Empresa.Application.Rubro.Validators
{
    public class EliminarRubroRequestValidator : AbstractValidator<EliminarRubroRequest>
    {
        public EliminarRubroRequestValidator()
        {
        }
    }
}
