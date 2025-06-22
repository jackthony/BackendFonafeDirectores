using FluentValidation;
using Empresa.Application.Rubro.Dtos;

namespace Empresa.Application.Rubro.Validators
{
    public class ListarRubroPaginadoRequestValidator : AbstractValidator<ListarRubroPaginadoRequest>
    {
        public ListarRubroPaginadoRequestValidator()
        {
        }
    }
}
