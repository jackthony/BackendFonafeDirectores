using FluentValidation;
using Empresa.Application.Ministerio.Dtos;

namespace Empresa.Application.Ministerio.Validators
{
    public class ListarMinisterioRequestValidator : AbstractValidator<ListarMinisterioRequest>
    {
        public ListarMinisterioRequestValidator()
        {
        }
    }
}
