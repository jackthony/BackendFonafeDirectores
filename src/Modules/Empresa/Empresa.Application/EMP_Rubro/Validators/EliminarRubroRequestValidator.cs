using FluentValidation;
using Empresa.Application.Rubro.Dtos;

namespace Empresa.Application.Rubro.Validators
{
    public class EliminarRubroRequestValidator : AbstractValidator<EliminarRubroRequest>
    {
        public EliminarRubroRequestValidator()
        {
        }
    }
}
