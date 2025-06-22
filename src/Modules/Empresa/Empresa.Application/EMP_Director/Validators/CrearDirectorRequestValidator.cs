using Empresa.Application.EMP_Director.Dtos;
using FluentValidation;

namespace Empresa.Application.EMP_Director.Validators
{
    public class CrearDirectorRequestValidator : AbstractValidator<CrearDirectorRequest>
    {
        public CrearDirectorRequestValidator()
        {
        }
    }
}
