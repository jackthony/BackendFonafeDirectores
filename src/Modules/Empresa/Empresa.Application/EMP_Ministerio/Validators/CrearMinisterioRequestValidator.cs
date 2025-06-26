using FluentValidation;
using Empresa.Application.Ministerio.Dtos;

namespace Empresa.Application.Ministerio.Validators
{
    public class CrearMinisterioRequestValidator : AbstractValidator<CrearMinisterioRequest>
    {
        public CrearMinisterioRequestValidator()
        {
        }
    }
}
