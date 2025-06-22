using FluentValidation;
using Empresa.Application.Empresa.Dtos;

namespace Empresa.Application.Empresa.Validators
{
    public class ListarEmpresaRequestValidator : AbstractValidator<ListarEmpresaRequest>
    {
        public ListarEmpresaRequestValidator()
        {
        }
    }
}
