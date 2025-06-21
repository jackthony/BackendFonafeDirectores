using Cargo.Application.Dtos;
using FluentValidation;

namespace Cargo.Application.Validators
{
    public class ListarCargoPaginadoRequestValidator : AbstractValidator<ListarCargoPaginadoRequest>
    {
        public ListarCargoPaginadoRequestValidator()
        {
        }
    }
}
