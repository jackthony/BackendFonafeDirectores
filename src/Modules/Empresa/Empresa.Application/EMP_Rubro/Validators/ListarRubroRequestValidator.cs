using FluentValidation;
using Empresa.Application.Rubro.Dtos;

namespace Empresa.Application.Rubro.Validators
{
    public class ListarRubroRequestValidator : AbstractValidator<ListarRubroRequest>
    {
        public ListarRubroRequestValidator()
        {
        }
    }
}
