using FluentValidation;
using Archivo.Application.Archivo.Dtos;

namespace Archivo.Application.Archivo.Validators
{
    public class CrearArchivoRequestValidator : AbstractValidator<CrearArchivoRequest>
    {
        public CrearArchivoRequestValidator()
        {
        }
    }
}
