using Archivo.Domain.Archivo.Results;
using Archivo.Presentation.Archivo.Responses;

namespace Archivo.Presentation.Archivo.Mappers
{
    public static class ArchivoResponseMapper
    {
        public static ArchivoResponse ToResponse(ArchivoResult dto) => new()
        {
        };

        public static IEnumerable<ArchivoResponse> ToListResponse(IEnumerable<ArchivoResult> items)
            => items.Select(ToResponse);
    }
}
