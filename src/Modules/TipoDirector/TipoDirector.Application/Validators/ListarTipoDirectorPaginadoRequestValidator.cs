using TipoDirector.Application.Dtos;
using FluentValidation;

namespace TipoDirector.Application.Validators
{
    public class ListarTipoDirectorPaginadoRequestValidator : AbstractValidator<ListarTipoDirectorPaginadoRequest>
    {
        public ListarTipoDirectorPaginadoRequestValidator()
        {
        }
    }
}
