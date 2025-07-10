/***********
* Nombre del archivo: ActualizarPermisoRolRequestValidator.cs
* Descripción:        Clase **validadora** para la solicitud de actualización de un permiso de rol existente.
*                     Define las reglas de validación que deben cumplir los datos de entrada
*                     al intentar modificar la información de un permiso asociado a un rol.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase validadora.
***********/

using FluentValidation;
using Usuario.Application.PermisoRol.Dtos;

namespace Usuario.Application.PermisoRol.Validators
{
    public class ActualizarPermisoRolRequestValidator : AbstractValidator<ActualizarPermisoRolRequest>
    {
        public ActualizarPermisoRolRequestValidator()
        {
        }
    }
}
