using Modulo.Application.Dtos;
using FluentValidation;

namespace Modulo.Application.Validators
{
    public class ListarModuloPaginadoRequestValidator : AbstractValidator<ListarModuloPaginadoRequest>
    {
        public ListarModuloPaginadoRequestValidator()
        {
        }
    }
}
