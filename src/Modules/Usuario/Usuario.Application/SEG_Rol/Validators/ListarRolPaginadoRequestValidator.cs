/***********
* Nombre del archivo: ListarRolPaginadoRequestValidator.cs
* Descripción:        Clase validadora para la solicitud de listar roles de forma paginada.
*                     Define las reglas de validación que deben cumplir los parámetros
*                     de entrada al solicitar una lista paginada de roles.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase validadora.
***********/

using FluentValidation;
using Usuario.Application.Rol.Dtos;

namespace Usuario.Application.Rol.Validators
{
    public class ListarRolPaginadoRequestValidator : AbstractValidator<ListarRolPaginadoRequest>
    {
        public ListarRolPaginadoRequestValidator()
        {
        }
    }
}
