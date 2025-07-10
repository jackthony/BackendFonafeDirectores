/*****
 * Nombre del archivo:  ListarDirectorRequestValidator.cs
 * Descripción:         Validador para la solicitud de listado de directores. Actualmente no tiene validaciones definidas.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   El validador está vacío por el momento, se podría agregar validaciones si es necesario más adelante.
 *****/
using FluentValidation;
using Empresa.Application.Director.Dtos;

namespace Empresa.Application.Director.Validators
{
    public class ListarDirectorRequestValidator : AbstractValidator<ListarDirectorRequest>
    {
        public ListarDirectorRequestValidator()
        {
        }
    }
}
