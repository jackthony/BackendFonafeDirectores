using Especialidad.Application.Dtos;
using FluentValidation;

namespace Especialidad.Application.Validators
{
    public class CrearEspecialidadRequestValidator : AbstractValidator<CrearEspecialidadRequest>
    {
        public CrearEspecialidadRequestValidator()
        {
        }
    }
}
