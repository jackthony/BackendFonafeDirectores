using Empresa.Application.EMP_Director.Dtos;
using FluentValidation;

namespace Empresa.Application.EMP_Director.Validators
{
    public class ActualizarDirectorRequestValidator : AbstractValidator<ActualizarDirectorRequest>
    {
        public ActualizarDirectorRequestValidator()
        {
        }
    }
}
