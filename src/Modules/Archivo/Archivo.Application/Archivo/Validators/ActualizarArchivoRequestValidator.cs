/*****
 * Nombre del archivo:  ActualizarArchivoRequestValidator.cs
 * Descripción:         Validador para la solicitud de actualización de archivo (`ActualizarArchivoRequest`). 
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
    public class ActualizarArchivoRequestValidator : AbstractValidator<ActualizarArchivoRequest>
    {
        public ActualizarArchivoRequestValidator()
        {
        }
    }
}
