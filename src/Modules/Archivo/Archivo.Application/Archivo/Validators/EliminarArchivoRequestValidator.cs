using FluentValidation;
using Archivo.Application.Archivo.Dtos;

namespace Archivo.Application.Archivo.Validators
{
    public class EliminarArchivoRequestValidator : AbstractValidator<EliminarArchivoRequest>
    {
        public EliminarArchivoRequestValidator()
        {
        }
    }
}
