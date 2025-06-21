using Usuario.Application.Dtos;
using FluentValidation;

namespace Usuario.Application.Validators
{
    public class CrearUsuarioRequestValidator : AbstractValidator<CrearUsuarioRequest>
    {
        public CrearUsuarioRequestValidator()
        {
        }
    }
}
