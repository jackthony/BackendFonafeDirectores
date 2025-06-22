using FluentValidation;
using Empresa.Application.Empresa.Dtos;

namespace Empresa.Application.Empresa.Validators
{
    public class EliminarEmpresaRequestValidator : AbstractValidator<EliminarEmpresaRequest>
    {
        public EliminarEmpresaRequestValidator()
        {
        }
    }
}
