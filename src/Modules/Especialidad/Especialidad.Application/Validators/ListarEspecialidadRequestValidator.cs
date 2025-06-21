using Especialidad.Application.Dtos;
using FluentValidation;

namespace Especialidad.Application.Validators
{
    public class ListarEspecialidadRequestValidator : AbstractValidator<ListarEspecialidadRequest>
    {
        public ListarEspecialidadRequestValidator()
        {
        }
    }
}
