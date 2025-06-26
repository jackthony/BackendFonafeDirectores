using FluentValidation;
using Empresa.Application.Rubro.Dtos;

namespace Empresa.Application.Rubro.Validators
{
    public class CrearRubroRequestValidator : AbstractValidator<CrearRubroRequest>
    {
        public CrearRubroRequestValidator()
        {
        }
    }
}
