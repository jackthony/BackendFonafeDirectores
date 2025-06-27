using Archivo.Domain.Archivo.Results;

namespace Archivo.Application.Archivo.Dtos
{
    public class ExportResponse
    {
        public List<EmpresaDocResult> EmpresaDocs { get; set; } = [];
        public List<DirectorDocResult> DirectorDocs { get; set; } = [];
    }
}
