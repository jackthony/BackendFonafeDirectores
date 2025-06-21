using Director.Application.Dtos;
using FluentValidation;

namespace Director.Application.Validators
{
    public class ListarDirectorRequestValidator : AbstractValidator<ListarDirectorRequest>
    {
        public ListarDirectorRequestValidator()
        {
        }
    }
}
