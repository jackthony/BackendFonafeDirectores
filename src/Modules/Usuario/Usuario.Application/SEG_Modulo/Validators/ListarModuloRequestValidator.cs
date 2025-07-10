/***********
* Nombre del archivo: ListarModuloRequestValidator.cs
* Descripción:        Clase validadora para la solicitud de listar módulos.
*                     Define las reglas de validación que deben cumplir los parámetros
*                     de entrada al solicitar una lista de módulos.
* Autor:              Daniel Alva
* Fecha de creación:  10/07/2025
* Última modificación:10/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase validadora.
***********/

using FluentValidation;
using Usuario.Application.Modulo.Dtos;

namespace Usuario.Application.Modulo.Validators
{
    public class ListarModuloRequestValidator : AbstractValidator<ListarModuloRequest>
    {
        public ListarModuloRequestValidator()
        {
        }
    }
}
