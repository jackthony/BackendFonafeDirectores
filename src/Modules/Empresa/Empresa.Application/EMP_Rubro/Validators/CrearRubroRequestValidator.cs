/*****
 * Nombre de clase:     CrearRubroRequestValidator
 * Descripción:         Validador para la clase CrearRubroRequest.
 *                      Se encarga de definir las reglas de validación para la
 *                      creación de un nuevo rubro.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase base creada sin reglas aún definidas.
 *****/

using FluentValidation;
using Empresa.Application.Rubro.Dtos;

namespace Empresa.Application.Rubro.Validators
{
    public class CrearRubroRequestValidator : AbstractValidator<CrearRubroRequest>
    {
        public CrearRubroRequestValidator()
        {
        }
    }
}
