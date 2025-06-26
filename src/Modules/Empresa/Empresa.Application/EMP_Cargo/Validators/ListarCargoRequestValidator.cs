using FluentValidation;
using Empresa.Application.Cargo.Dtos;

namespace Empresa.Application.Cargo.Validators
{
    public class ListarCargoRequestValidator : AbstractValidator<ListarCargoRequest>
    {
        public ListarCargoRequestValidator()
        {
        }
    }
}
