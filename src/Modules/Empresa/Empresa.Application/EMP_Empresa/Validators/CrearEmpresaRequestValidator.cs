using FluentValidation;
using Empresa.Application.Empresa.Dtos;

namespace Empresa.Application.Empresa.Validators
{
    public class CrearEmpresaRequestValidator : AbstractValidator<CrearEmpresaRequest>
    {
        public CrearEmpresaRequestValidator()
        {
        }
    }
}
