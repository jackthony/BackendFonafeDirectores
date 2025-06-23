using FluentValidation;
using Empresa.Application.Ubigeo.Dtos;

namespace Empresa.Application.Ubigeo.Validators
{
    public class ListarUbigeoPaginadoRequestValidator : AbstractValidator<ListarUbigeoPaginadoRequest>
    {
        public ListarUbigeoPaginadoRequestValidator()
        {
        }
    }
}
