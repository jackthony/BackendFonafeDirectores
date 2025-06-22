using Empresa.Application.EMP_Ministerio.Dtos;
using FluentValidation;

namespace Empresa.Application.EMP_Ministerio.Validators
{
    public class ListarMinisterioRequestValidator : AbstractValidator<ListarMinisterioRequest>
    {
        public ListarMinisterioRequestValidator()
        {
        }
    }
}
