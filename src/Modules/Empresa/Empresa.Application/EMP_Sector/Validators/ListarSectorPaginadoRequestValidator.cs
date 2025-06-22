using FluentValidation;
using Empresa.Application.Sector.Dtos;

namespace Empresa.Application.Sector.Validators
{
    public class ListarSectorPaginadoRequestValidator : AbstractValidator<ListarSectorPaginadoRequest>
    {
        public ListarSectorPaginadoRequestValidator()
        {
        }
    }
}
