/***********
* Nombre del archivo: CrearRolRequestValidator.cs
* Descripción:        Clase validadora para la solicitud de creación de un nuevo rol.
*                     Define las reglas de validación que deben cumplir los datos de entrada
*                     al intentar registrar un nuevo rol en el sistema.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase validadora.
***********/

using FluentValidation;
using Usuario.Application.Rol.Dtos;

namespace Usuario.Application.Rol.Validators
{
    public class CrearRolRequestValidator : AbstractValidator<CrearRolRequest>
    {
        public CrearRolRequestValidator()
        {
        }
    }
}
