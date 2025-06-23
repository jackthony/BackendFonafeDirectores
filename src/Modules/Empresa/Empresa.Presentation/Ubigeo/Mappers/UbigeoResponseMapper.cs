using Empresa.Domain.Ubigeo.Results;
using Empresa.Presentation.Ubigeo.Responses;

namespace Empresa.Presentation.Ubigeo.Mappers
{
    public static class UbigeoResponseMapper
    {
        public static UbigeoResponse ToResponse(UbigeoResult dto) => new()
        {
        };

        public static IEnumerable<UbigeoResponse> ToListResponse(IEnumerable<UbigeoResult> items)
            => items.Select(ToResponse);
    }
}
