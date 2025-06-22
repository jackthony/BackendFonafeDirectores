using FluentValidation;
using Empresa.Application.Director.Dtos;

namespace Empresa.Application.Director.Validators
{
    public class ListarDirectorPaginadoRequestValidator : AbstractValidator<ListarDirectorPaginadoRequest>
    {
        public ListarDirectorPaginadoRequestValidator()
        {
        }
    }
}
