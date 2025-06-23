using FluentValidation;
using Empresa.Application.Ubigeo.Dtos;

namespace Empresa.Application.Ubigeo.Validators
{
    public class CrearUbigeoRequestValidator : AbstractValidator<CrearUbigeoRequest>
    {
        public CrearUbigeoRequestValidator()
        {
        }
    }
}
