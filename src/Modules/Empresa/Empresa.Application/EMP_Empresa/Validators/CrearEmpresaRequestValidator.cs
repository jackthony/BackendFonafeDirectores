using Empresa.Application.EMP_Empresa.Dtos;
using FluentValidation;

namespace Empresa.Application.EMP_Empresa.Validators
{
    public class CrearEmpresaRequestValidator : AbstractValidator<CrearEmpresaRequest>
    {
        public CrearEmpresaRequestValidator()
        {
        }
    }
}
