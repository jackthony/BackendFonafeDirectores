using FluentValidation;
using Empresa.Application.Ministerio.Dtos;

namespace Empresa.Application.Ministerio.Validators
{
    public class EliminarMinisterioRequestValidator : AbstractValidator<EliminarMinisterioRequest>
    {
        public EliminarMinisterioRequestValidator()
        {
        }
    }
}
