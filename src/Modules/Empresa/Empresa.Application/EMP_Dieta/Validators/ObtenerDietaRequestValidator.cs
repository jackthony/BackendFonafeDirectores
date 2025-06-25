using Empresa.Application.Dieta.Dtos;
using FluentValidation;

namespace Empresa.Application.Dieta.Validators
{
    public class ObtenerDietaRequestValidator : AbstractValidator<ObtenerDietaRequest>
    {
        public ObtenerDietaRequestValidator()
        {
        }
    }
}
