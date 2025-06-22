using FluentValidation;
using Empresa.Application.Ministerio.Dtos;

namespace Empresa.Application.Ministerio.Validators
{
    public class ListarMinisterioPaginadoRequestValidator : AbstractValidator<ListarMinisterioPaginadoRequest>
    {
        public ListarMinisterioPaginadoRequestValidator()
        {
        }
    }
}
