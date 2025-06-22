using FluentValidation;
using Empresa.Application.Especialidad.Dtos;

namespace Empresa.Application.Especialidad.Validators
{
    public class ListarEspecialidadPaginadoRequestValidator : AbstractValidator<ListarEspecialidadPaginadoRequest>
    {
        public ListarEspecialidadPaginadoRequestValidator()
        {
        }
    }
}
