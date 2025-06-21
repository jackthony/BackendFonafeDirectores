using Accion.Application.Dtos;
using FluentValidation;

namespace Accion.Application.Validators
{
    public class ListarAccionPaginadoRequestValidator : AbstractValidator<ListarAccionPaginadoRequest>
    {
        public ListarAccionPaginadoRequestValidator()
        {
        }
    }
}
