using Archivo.Application.Archivo.Dtos;
using Archivo.Domain.Archivo.Parameters;
using Shared.Kernel.Interfaces;

namespace Archivo.Application.Archivo.Mappers
{
    public class ExportFileRequestMapper : IMapper<ExportFileRequest, ExportParameters>
    {
        public ExportParameters Map(ExportFileRequest request)
        {
            return new ExportParameters
            {
            };
        }
    }
}
