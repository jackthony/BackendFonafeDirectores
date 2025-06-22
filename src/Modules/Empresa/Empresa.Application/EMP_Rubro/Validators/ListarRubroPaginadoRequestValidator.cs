using Empresa.Application.EMP_Rubro.Dtos;
using FluentValidation;

namespace Empresa.Application.EMP_Rubro.Validators
{
    public class ListarRubroPaginadoRequestValidator : AbstractValidator<ListarRubroPaginadoRequest>
    {
        public ListarRubroPaginadoRequestValidator()
        {
        }
    }
}
