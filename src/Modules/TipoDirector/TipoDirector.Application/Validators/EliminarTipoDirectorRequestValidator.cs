using TipoDirector.Application.Dtos;
using FluentValidation;

namespace TipoDirector.Application.Validators
{
    public class EliminarTipoDirectorRequestValidator : AbstractValidator<EliminarTipoDirectorRequest>
    {
        public EliminarTipoDirectorRequestValidator()
        {
        }
    }
}
