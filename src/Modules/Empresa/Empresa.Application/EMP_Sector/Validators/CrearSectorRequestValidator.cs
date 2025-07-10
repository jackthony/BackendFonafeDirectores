/*****
 * Nombre del archivo:  CrearSectorRequestValidator.cs
 * Descripción:         Validador para la solicitud de creación de sector. Hereda de AbstractValidator
 *                      y define las reglas de validación para el DTO CrearSectorRequest.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using FluentValidation;
using Empresa.Application.Sector.Dtos;

namespace Empresa.Application.Sector.Validators
{
    public class CrearSectorRequestValidator : AbstractValidator<CrearSectorRequest>
    {
        public CrearSectorRequestValidator()
        {
        }
    }
}
