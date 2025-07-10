/*****
 * Nombre del archivo:  ListarArchivoRequestValidator.cs
 * Descripción:         Validador para la solicitud de listado de archivos (`ListarArchivoRequest`). 
 *                      Utiliza FluentValidation para validar las propiedades de la solicitud antes de procesarla.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using FluentValidation;
using Archivo.Application.Archivo.Dtos;

namespace Archivo.Application.Archivo.Validators
{
    public class ListarArchivoRequestValidator : AbstractValidator<ListarArchivoRequest>
    {
        public ListarArchivoRequestValidator()
        {
        }
    }
}
