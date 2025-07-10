/*****
 * Nombre del archivo:  ListarDistritoRequestValidator.cs
 * Descripción:         Validador para la solicitud de listado de distritos. Hereda de AbstractValidator
 *                      y define las reglas de validación para el DTO ListarDistritoRequest.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using Empresa.Application.Ubigeo.Dtos;
using FluentValidation;

namespace Empresa.Application.Ubigeo.Validators
{
    public class ListarDistritoRequestValidator : AbstractValidator<ListarDistritoRequest>
    {
        public ListarDistritoRequestValidator()
        {
        }
    }
}
