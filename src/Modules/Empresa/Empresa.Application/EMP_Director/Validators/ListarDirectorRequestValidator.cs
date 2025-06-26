using FluentValidation;
using Empresa.Application.Director.Dtos;

namespace Empresa.Application.Director.Validators
{
    public class ListarDirectorRequestValidator : AbstractValidator<ListarDirectorRequest>
    {
        public ListarDirectorRequestValidator()
        {
        }
    }
}
