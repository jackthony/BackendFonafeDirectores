using FluentValidation;
using Empresa.Application.Especialidad.Dtos;

namespace Empresa.Application.Especialidad.Validators
{
    public class CrearEspecialidadRequestValidator : AbstractValidator<CrearEspecialidadRequest>
    {
        public CrearEspecialidadRequestValidator()
        {
        }
    }
}
