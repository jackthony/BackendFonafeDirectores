using Empresa.Application.Ubigeo.Dtos;
using FluentValidation;

namespace Empresa.Application.Ubigeo.Validators
{
    public class ListarProvinciaRequestValidator : AbstractValidator<ListarProvinciaRequest>
    {
        public ListarProvinciaRequestValidator()
        {
        }
    }
}
