/***********
* Nombre del archivo: ActualizarRolRequestValidator.cs
* Descripción:        Clase validadora para la solicitud de actualización de un rol existente.
*                     Define las reglas de validación que deben cumplir los datos de entrada
*                     al intentar modificar la información de un rol.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase validadora.
***********/

using FluentValidation;
using Usuario.Application.Rol.Dtos;

namespace Usuario.Application.Rol.Validators
{
    public class ActualizarRolRequestValidator : AbstractValidator<ActualizarRolRequest>
    {
        public ActualizarRolRequestValidator()
        {
        }
    }
}
