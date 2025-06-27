using FluentValidation;
using Empresa.Application.Empresa.Dtos;

namespace Empresa.Application.Empresa.Validators
{
    public class ListarEmpresaPaginadoRequestValidator : AbstractValidator<ListarEmpresaPaginadoRequest>
    {
        public ListarEmpresaPaginadoRequestValidator()
        {
        }
    }
}
