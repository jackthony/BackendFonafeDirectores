using Director.Application.Dtos;
using FluentValidation;

namespace Director.Application.Validators
{
    public class CrearDirectorRequestValidator : AbstractValidator<CrearDirectorRequest>
    {
        public CrearDirectorRequestValidator()
        {
        }
    }
}
