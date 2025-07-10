/*****
 * Nombre del archivo:  ListarArchivoPaginadoRequestValidator.cs
 * Descripción:         Validador para la solicitud de listado paginado de archivos (`ListarArchivoPaginadoRequest`). 
 *                      Utiliza FluentValidation para validar las propiedades de la solicitud antes de procesarla.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using FluentValidation;
using Archivo.Application.Archivo.Dtos;

namespace Archivo.Application.Archivo.Validators
{
    public class ListarArchivoPaginadoRequestValidator : AbstractValidator<ListarArchivoPaginadoRequest>
    {
        public ListarArchivoPaginadoRequestValidator()
        {
        }
    }
}
