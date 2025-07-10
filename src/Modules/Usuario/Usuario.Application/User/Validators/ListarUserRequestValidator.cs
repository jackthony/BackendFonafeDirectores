/***********
* Nombre del archivo: ListarUserRequestValidator.cs
* Descripción:        Clase validadora para la solicitud de listar usuarios.
*                     Define las reglas de validación que deben cumplir los parámetros
*                     de entrada al solicitar una lista de usuarios.
* Autor:              Daniel Alva
* Fecha de creación:  09/07/2025
* Última modificación:09/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase validadora.
***********/

using FluentValidation;
using Usuario.Application.User.Dtos;

namespace Usuario.Application.User.Validators
{
    public class ListarUserRequestValidator : AbstractValidator<ListarUserRequest>
    {
        public ListarUserRequestValidator()
        {
        }
    }
}
