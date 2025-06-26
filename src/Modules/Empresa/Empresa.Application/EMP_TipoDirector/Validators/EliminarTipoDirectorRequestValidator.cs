using FluentValidation;
using Empresa.Application.TipoDirector.Dtos;

namespace Empresa.Application.TipoDirector.Validators
{
    public class EliminarTipoDirectorRequestValidator : AbstractValidator<EliminarTipoDirectorRequest>
    {
        public EliminarTipoDirectorRequestValidator()
        {
        }
    }
}
