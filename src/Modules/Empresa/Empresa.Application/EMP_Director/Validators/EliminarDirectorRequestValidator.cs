using FluentValidation;
using Empresa.Application.Director.Dtos;

namespace Empresa.Application.Director.Validators
{
    public class EliminarDirectorRequestValidator : AbstractValidator<EliminarDirectorRequest>
    {
        public EliminarDirectorRequestValidator()
        {
        }
    }
}
