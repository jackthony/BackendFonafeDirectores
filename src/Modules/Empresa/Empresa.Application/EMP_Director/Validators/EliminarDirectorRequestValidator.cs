using Empresa.Application.EMP_Director.Dtos;
using FluentValidation;

namespace Empresa.Application.EMP_Director.Validators
{
    public class EliminarDirectorRequestValidator : AbstractValidator<EliminarDirectorRequest>
    {
        public EliminarDirectorRequestValidator()
        {
        }
    }
}
