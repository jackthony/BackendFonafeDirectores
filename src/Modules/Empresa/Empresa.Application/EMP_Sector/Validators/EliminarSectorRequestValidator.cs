using FluentValidation;
using Empresa.Application.Sector.Dtos;

namespace Empresa.Application.Sector.Validators
{
    public class EliminarSectorRequestValidator : AbstractValidator<EliminarSectorRequest>
    {
        public EliminarSectorRequestValidator()
        {
        }
    }
}
