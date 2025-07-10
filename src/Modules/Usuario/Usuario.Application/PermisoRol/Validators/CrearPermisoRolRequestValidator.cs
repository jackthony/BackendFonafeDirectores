/***********
* Nombre del archivo: CrearPermisoRolRequestValidator.cs
* Descripción:        Clase **validadora** para la solicitud de creación de un nuevo permiso de rol.
*                     Define las reglas de validación que deben cumplir los datos de entrada
*                     al intentar registrar un nuevo permiso para un rol en el sistema.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase validadora.
***********/

using FluentValidation;
using Usuario.Application.PermisoRol.Dtos;

namespace Usuario.Application.PermisoRol.Validators
{
    public class CrearPermisoRolRequestValidator : AbstractValidator<CrearPermisoRolRequest>
    {
        public CrearPermisoRolRequestValidator()
        {
        }
    }
}
