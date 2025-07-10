/*****
 * Nombre de clase:     ListarRubroRequestValidator
 * Descripción:         Validador para la clase ListarRubroRequest. 
 *                      Encargado de definir las reglas de validación para 
 *                      la solicitud de listado de rubros sin paginación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase base de validador sin reglas implementadas aún.
 *****/

using FluentValidation;
using Empresa.Application.Rubro.Dtos;

namespace Empresa.Application.Rubro.Validators
{
    public class ListarRubroRequestValidator : AbstractValidator<ListarRubroRequest>
    {
        public ListarRubroRequestValidator()
        {
        }
    }
}
