using FluentValidation;
using Empresa.Application.Cargo.Dtos;

namespace Empresa.Application.Cargo.Validators
{
    public class ListarCargoPaginadoRequestValidator : AbstractValidator<ListarCargoPaginadoRequest>
    {
        public ListarCargoPaginadoRequestValidator()
        {
        }
    }
}
