/***********
* Nombre del archivo: EliminarModuloRequestValidator.cs
* Descripción:        Clase validadora para la solicitud de eliminación de un módulo.
*                     Define las reglas de validación que deben cumplir los parámetros
*                     de entrada al solicitar la eliminación de un módulo.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase validadora.
***********/

using FluentValidation;
using Usuario.Application.Modulo.Dtos;

namespace Usuario.Application.Modulo.Validators
{
    public class EliminarModuloRequestValidator : AbstractValidator<EliminarModuloRequest>
    {
        public EliminarModuloRequestValidator()
        {
        }
    }
}
