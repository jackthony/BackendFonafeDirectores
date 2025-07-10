/***********
* Nombre del archivo: ListarPermisoRolRequestValidator.cs
* Descripción:        Clase validadora para la solicitud de listar permisos de rol.
*                     Define las reglas de validación que deben cumplir los parámetros
*                     de entrada al solicitar una lista de permisos de rol.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase validadora.
***********/

using FluentValidation;
using Usuario.Application.PermisoRol.Dtos;

namespace Usuario.Application.PermisoRol.Validators
{
    public class ListarPermisoRolRequestValidator : AbstractValidator<ListarPermisoRolRequest>
    {
        public ListarPermisoRolRequestValidator()
        {
        }
    }
}
