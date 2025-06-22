using FluentValidation;
using Empresa.Application.Ministerio.Dtos;

namespace Empresa.Application.Ministerio.Validators
{
    public class ActualizarMinisterioRequestValidator : AbstractValidator<ActualizarMinisterioRequest>
    {
        public ActualizarMinisterioRequestValidator()
        {
        }
    }
}
