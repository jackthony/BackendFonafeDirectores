/***********
* Nombre del archivo: ListarRolRequestValidator.cs
* Descripción:        Clase validadora para la solicitud de listar roles.
*                     Define las reglas de validación que deben cumplir los parámetros
*                     de entrada al solicitar una lista de roles.
* Autor:              Daniel Alva
* Fecha de creación:  10/07/2025
* Última modificación:10/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase validadora.
***********/

using FluentValidation;
using Usuario.Application.Rol.Dtos;

namespace Usuario.Application.Rol.Validators
{
    public class ListarRolRequestValidator : AbstractValidator<ListarRolRequest>
    {
        public ListarRolRequestValidator()
        {
        }
    }
}
