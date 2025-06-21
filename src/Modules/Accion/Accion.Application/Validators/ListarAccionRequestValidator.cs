using Accion.Application.Dtos;
using FluentValidation;

namespace Accion.Application.Validators
{
    public class ListarAccionRequestValidator : AbstractValidator<ListarAccionRequest>
    {
        public ListarAccionRequestValidator()
        {
        }
    }
}
