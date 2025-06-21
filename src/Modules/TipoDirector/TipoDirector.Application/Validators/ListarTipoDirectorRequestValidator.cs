using TipoDirector.Application.Dtos;
using FluentValidation;

namespace TipoDirector.Application.Validators
{
    public class ListarTipoDirectorRequestValidator : AbstractValidator<ListarTipoDirectorRequest>
    {
        public ListarTipoDirectorRequestValidator()
        {
        }
    }
}
