using FluentValidation;
using Empresa.Application.TipoDirector.Dtos;

namespace Empresa.Application.TipoDirector.Validators
{
    public class ListarTipoDirectorPaginadoRequestValidator : AbstractValidator<ListarTipoDirectorPaginadoRequest>
    {
        public ListarTipoDirectorPaginadoRequestValidator()
        {
        }
    }
}
