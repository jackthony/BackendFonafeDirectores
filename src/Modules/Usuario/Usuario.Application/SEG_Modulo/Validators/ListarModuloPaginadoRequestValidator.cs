using FluentValidation;
using Usuario.Application.Modulo.Dtos;

namespace Usuario.Application.Modulo.Validators
{
    public class ListarModuloPaginadoRequestValidator : AbstractValidator<ListarModuloPaginadoRequest>
    {
        public ListarModuloPaginadoRequestValidator()
        {
        }
    }
}
