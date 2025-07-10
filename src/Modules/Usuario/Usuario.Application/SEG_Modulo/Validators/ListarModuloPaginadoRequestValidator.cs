/***********
* Nombre del archivo: ListarModuloPaginadoRequestValidator.cs
* Descripción:        Clase validadora para la solicitud de listar módulos de forma paginada.
*                     Define las reglas de validación que deben cumplir los parámetros
*                     de entrada al solicitar una lista paginada de módulos.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase validadora.
***********/

using FluentValidation;
using Usuario.Application.Modulo.Dtos;

namespace Usuario.Application.Modulo.Validators
{
    public class ListarModuloPaginadoRequestValidator : AbstractValidator<ListarModuloPaginadoRequest>
    {
        public ListarModuloPaginadoRequestValidator()
        {
        }
    }
}
