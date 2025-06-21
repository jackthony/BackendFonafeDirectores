using Empresa.Application.Dtos;
using FluentValidation;

namespace Empresa.Application.Validators
{
    public class CrearEmpresaRequestValidator : AbstractValidator<CrearEmpresaRequest>
    {
        public CrearEmpresaRequestValidator()
        {
        }
    }
}
