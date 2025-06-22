using Empresa.Application.EMP_Rubro.Dtos;
using FluentValidation;

namespace Empresa.Application.EMP_Rubro.Validators
{
    public class CrearRubroRequestValidator : AbstractValidator<CrearRubroRequest>
    {
        public CrearRubroRequestValidator()
        {
        }
    }
}
