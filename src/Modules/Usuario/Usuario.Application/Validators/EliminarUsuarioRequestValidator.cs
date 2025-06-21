using Usuario.Application.Dtos;
using FluentValidation;

namespace Usuario.Application.Validators
{
    public class EliminarUsuarioRequestValidator : AbstractValidator<EliminarUsuarioRequest>
    {
        public EliminarUsuarioRequestValidator()
        {
        }
    }
}
