/***********
* Nombre del archivo: EliminarRolRequestValidator.cs
* Descripción:        Clase validadora para la solicitud de eliminación de un rol.
*                     Define las reglas de validación que deben cumplir los parámetros
*                     de entrada al solicitar la eliminación de un rol.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase validadora.
***********/

using FluentValidation;
using Usuario.Application.Rol.Dtos;

namespace Usuario.Application.Rol.Validators
{
    public class EliminarRolRequestValidator : AbstractValidator<EliminarRolRequest>
    {
        public EliminarRolRequestValidator()
        {
        }
    }
}
