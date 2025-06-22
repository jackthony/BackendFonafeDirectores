using FluentValidation;
using Empresa.Application.Director.Dtos;

namespace Empresa.Application.Director.Validators
{
    public class ActualizarDirectorRequestValidator : AbstractValidator<ActualizarDirectorRequest>
    {
        public ActualizarDirectorRequestValidator()
        {
        }
    }
}
