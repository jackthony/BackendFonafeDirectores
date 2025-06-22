using FluentValidation;
using Empresa.Application.Especialidad.Dtos;

namespace Empresa.Application.Especialidad.Validators
{
    public class ListarEspecialidadRequestValidator : AbstractValidator<ListarEspecialidadRequest>
    {
        public ListarEspecialidadRequestValidator()
        {
        }
    }
}
