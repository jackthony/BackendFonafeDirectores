using Empresa.Application.EMP_Ministerio.Dtos;
using FluentValidation;

namespace Empresa.Application.EMP_Ministerio.Validators
{
    public class EliminarMinisterioRequestValidator : AbstractValidator<EliminarMinisterioRequest>
    {
        public EliminarMinisterioRequestValidator()
        {
        }
    }
}
