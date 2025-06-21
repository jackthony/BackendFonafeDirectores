using Sector.Application.Dtos;
using FluentValidation;

namespace Sector.Application.Validators
{
    public class ListarSectorRequestValidator : AbstractValidator<ListarSectorRequest>
    {
        public ListarSectorRequestValidator()
        {
        }
    }
}
