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
