using Empresa.Application.EMP_Especialidad.Dtos;
using FluentValidation;

namespace Empresa.Application.EMP_Especialidad.Validators
{
    public class EliminarEspecialidadRequestValidator : AbstractValidator<EliminarEspecialidadRequest>
    {
        public EliminarEspecialidadRequestValidator()
        {
        }
    }
}
