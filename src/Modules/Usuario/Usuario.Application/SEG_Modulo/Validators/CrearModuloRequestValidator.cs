/***********
* Nombre del archivo: CrearModuloRequestValidator.cs
* Descripción:        Clase validadora para la solicitud de creación de un nuevo módulo.
*                     Define las reglas de validación que deben cumplir los datos de entrada
*                     al intentar registrar un nuevo módulo en el sistema.
* Autor:              Daniel Alva
* Fecha de creación:  10/07/2025
* Última modificación:10/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase validadora.
***********/

using FluentValidation;
using Usuario.Application.Modulo.Dtos;

namespace Usuario.Application.Modulo.Validators
{
    public class CrearModuloRequestValidator : AbstractValidator<CrearModuloRequest>
    {
        public CrearModuloRequestValidator()
        {
        }
    }
}
