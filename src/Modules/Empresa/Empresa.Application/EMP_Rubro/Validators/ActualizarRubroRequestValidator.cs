using FluentValidation;
using Empresa.Application.Rubro.Dtos;

namespace Empresa.Application.Rubro.Validators
{
    public class ActualizarRubroRequestValidator : AbstractValidator<ActualizarRubroRequest>
    {
        public ActualizarRubroRequestValidator()
        {
        }
    }
}
