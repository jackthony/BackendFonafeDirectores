using FluentValidation;
using Empresa.Application.Especialidad.Dtos;

namespace Empresa.Application.Especialidad.Validators
{
    public class ActualizarEspecialidadRequestValidator : AbstractValidator<ActualizarEspecialidadRequest>
    {
        public ActualizarEspecialidadRequestValidator()
        {
        }
    }
}
