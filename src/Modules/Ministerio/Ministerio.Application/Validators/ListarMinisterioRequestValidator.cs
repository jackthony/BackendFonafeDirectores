using Ministerio.Application.Dtos;
using FluentValidation;

namespace Ministerio.Application.Validators
{
    public class ListarMinisterioRequestValidator : AbstractValidator<ListarMinisterioRequest>
    {
        public ListarMinisterioRequestValidator()
        {
        }
    }
}
