using FluentValidation;
using Empresa.Application.Especialidad.Dtos;

namespace Empresa.Application.Especialidad.Validators
{
    public class EliminarEspecialidadRequestValidator : AbstractValidator<EliminarEspecialidadRequest>
    {
        public EliminarEspecialidadRequestValidator()
        {
        }
    }
}
