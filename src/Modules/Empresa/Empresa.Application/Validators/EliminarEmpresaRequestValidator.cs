using Empresa.Application.Dtos;
using FluentValidation;

namespace Empresa.Application.Validators
{
    public class EliminarEmpresaRequestValidator : AbstractValidator<EliminarEmpresaRequest>
    {
        public EliminarEmpresaRequestValidator()
        {
        }
    }
}
