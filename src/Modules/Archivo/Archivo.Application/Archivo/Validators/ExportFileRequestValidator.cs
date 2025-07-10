/*****
 * Nombre del archivo:  ExportFileRequestValidator.cs
 * Descripción:         Validador para la solicitud de exportación de archivo (`ExportFileRequest`). 
 *                      Utiliza FluentValidation para validar el tipo de archivo (`nTipoArchivo`), permitiendo solo los valores 1 o 2.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using FluentValidation;
using Archivo.Application.Archivo.Dtos;

namespace Archivo.Application.Archivo.Validators
{
    public class ExportFileRequestValidator : AbstractValidator<ExportFileRequest>
    {
        public ExportFileRequestValidator()
        {
            RuleFor(x => x.nTipoArchivo)
                .Must(t => t == 1 || t == 2)
                .WithMessage("No se reconoce el tipo de archivo. Solo se permiten los valores 1 o 2.");
        }
    }
}
