using Empresa.Application.EMP_Sector.Dtos;
using FluentValidation;

namespace Empresa.Application.EMP_Sector.Validators
{
    public class EliminarSectorRequestValidator : AbstractValidator<EliminarSectorRequest>
    {
        public EliminarSectorRequestValidator()
        {
        }
    }
}
