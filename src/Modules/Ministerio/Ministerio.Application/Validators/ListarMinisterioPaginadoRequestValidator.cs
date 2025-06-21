using Ministerio.Application.Dtos;
using FluentValidation;

namespace Ministerio.Application.Validators
{
    public class ListarMinisterioPaginadoRequestValidator : AbstractValidator<ListarMinisterioPaginadoRequest>
    {
        public ListarMinisterioPaginadoRequestValidator()
        {
        }
    }
}
