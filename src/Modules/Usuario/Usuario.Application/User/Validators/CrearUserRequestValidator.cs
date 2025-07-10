/***********
* Nombre del archivo: CrearUserRequestValidator.cs
* Descripción:        Clase validadora para la solicitud de creación de un nuevo usuario.
*                     Define las reglas de validación que deben cumplir los datos de entrada
*                     al intentar registrar un nuevo usuario en el sistema.
* Autor:              Daniel Alva
* Fecha de creación:  09/07/2025
* Última modificación:09/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase validadora.
***********/

using FluentValidation;
using Usuario.Application.User.Dtos;

namespace Usuario.Application.User.Validators
{
    public class CrearUserRequestValidator : AbstractValidator<CrearUserRequest>
    {
        public CrearUserRequestValidator()
        {
        }
    }
}
