using FluentValidation;
using Empresa.Application.Empresa.Dtos;

namespace Empresa.Application.Empresa.Validators
{
    public class ActualizarEmpresaRequestValidator : AbstractValidator<ActualizarEmpresaRequest>
    {
        public ActualizarEmpresaRequestValidator()
        {
        }
    }
}
