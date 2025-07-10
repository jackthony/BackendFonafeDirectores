/***********
* Nombre del archivo: ActualizarUserRequestValidator.cs
* Descripción:        Clase validadora para la solicitud de actualización de un usuario existente.
*                     Define las reglas de validación que deben cumplir los datos de entrada
*                     al intentar modificar la información de un usuario.
* Autor:              Daniel Alva
* Fecha de creación:  09/07/2025
* Última modificación:09/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase validadora.
***********/

using FluentValidation;
using Usuario.Application.User.Dtos;

namespace Usuario.Application.User.Validators
{
    public class ActualizarUserRequestValidator : AbstractValidator<ActualizarUserRequest>
    {
        public ActualizarUserRequestValidator()
        {
        }
    }
}
