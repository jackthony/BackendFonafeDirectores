using Empresa.Application.EMP_Especialidad.Dtos;
using FluentValidation;

namespace Empresa.Application.EMP_Especialidad.Validators
{
    public class ListarEspecialidadRequestValidator : AbstractValidator<ListarEspecialidadRequest>
    {
        public ListarEspecialidadRequestValidator()
        {
        }
    }
}
