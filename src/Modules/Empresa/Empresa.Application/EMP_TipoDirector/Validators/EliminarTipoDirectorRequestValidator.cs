using Empresa.Application.EMP_TipoDirector.Dtos;
using FluentValidation;

namespace Empresa.Application.EMP_TipoDirector.Validators
{
    public class EliminarTipoDirectorRequestValidator : AbstractValidator<EliminarTipoDirectorRequest>
    {
        public EliminarTipoDirectorRequestValidator()
        {
        }
    }
}
