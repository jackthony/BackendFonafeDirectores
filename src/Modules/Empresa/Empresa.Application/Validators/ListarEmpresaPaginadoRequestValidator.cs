using Empresa.Application.Dtos;
using FluentValidation;

namespace Empresa.Application.Validators
{
    public class ListarEmpresaPaginadoRequestValidator : AbstractValidator<ListarEmpresaPaginadoRequest>
    {
        public ListarEmpresaPaginadoRequestValidator()
        {
        }
    }
}
