using Especialidad.Application.Dtos;
using FluentValidation;

namespace Especialidad.Application.Validators
{
    public class ListarEspecialidadPaginadoRequestValidator : AbstractValidator<ListarEspecialidadPaginadoRequest>
    {
        public ListarEspecialidadPaginadoRequestValidator()
        {
        }
    }
}
