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
