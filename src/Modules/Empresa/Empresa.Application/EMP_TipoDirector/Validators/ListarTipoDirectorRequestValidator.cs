using FluentValidation;
using Empresa.Application.TipoDirector.Dtos;

namespace Empresa.Application.TipoDirector.Validators
{
    public class ListarTipoDirectorRequestValidator : AbstractValidator<ListarTipoDirectorRequest>
    {
        public ListarTipoDirectorRequestValidator()
        {
        }
    }
}
