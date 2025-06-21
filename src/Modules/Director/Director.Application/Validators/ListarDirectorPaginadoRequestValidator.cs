using Director.Application.Dtos;
using FluentValidation;

namespace Director.Application.Validators
{
    public class ListarDirectorPaginadoRequestValidator : AbstractValidator<ListarDirectorPaginadoRequest>
    {
        public ListarDirectorPaginadoRequestValidator()
        {
        }
    }
}
