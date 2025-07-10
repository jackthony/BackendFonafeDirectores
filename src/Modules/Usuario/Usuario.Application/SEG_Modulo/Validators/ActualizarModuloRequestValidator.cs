/***********
* Nombre del archivo: ActualizarModuloRequestValidator.cs
* Descripción:        Clase validadora para la solicitud de actualización de un módulo existente.
*                     Define las reglas de validación que deben cumplir los datos de entrada
*                     al intentar modificar la información de un módulo.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase validadora.
***********/

using FluentValidation;
using Usuario.Application.Modulo.Dtos;

namespace Usuario.Application.Modulo.Validators
{
    public class ActualizarModuloRequestValidator : AbstractValidator<ActualizarModuloRequest>
    {
        public ActualizarModuloRequestValidator()
        {
        }
    }
}
