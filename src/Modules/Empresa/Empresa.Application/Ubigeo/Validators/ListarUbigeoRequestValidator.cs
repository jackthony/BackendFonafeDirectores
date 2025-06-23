using FluentValidation;
using Empresa.Application.Ubigeo.Dtos;

namespace Empresa.Application.Ubigeo.Validators
{
    public class ListarUbigeoRequestValidator : AbstractValidator<ListarUbigeoRequest>
    {
        public ListarUbigeoRequestValidator()
        {
        }
    }
}
