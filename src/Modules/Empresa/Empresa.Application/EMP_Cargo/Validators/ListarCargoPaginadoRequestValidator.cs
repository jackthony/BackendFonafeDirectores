using Empresa.Application.EMP_Cargo.Dtos;
using FluentValidation;

namespace Empresa.Application.EMP_Cargo.Validators
{
    public class ListarCargoPaginadoRequestValidator : AbstractValidator<ListarCargoPaginadoRequest>
    {
        public ListarCargoPaginadoRequestValidator()
        {
        }
    }
}
