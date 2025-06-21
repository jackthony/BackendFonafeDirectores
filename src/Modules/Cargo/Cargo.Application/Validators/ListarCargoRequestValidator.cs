using Cargo.Application.Dtos;
using FluentValidation;

namespace Cargo.Application.Validators
{
    public class ListarCargoRequestValidator : AbstractValidator<ListarCargoRequest>
    {
        public ListarCargoRequestValidator()
        {
        }
    }
}
