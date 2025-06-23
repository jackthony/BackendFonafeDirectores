using Archivo.Application.Archivo.Dtos;
using Archivo.Domain.Archivo.Results;

namespace Archivo.Application.Archivo.Services
{
    public interface IExportImportService
    {
        public Stream ExportAsync(List<EmpresaDocResult> empresas, List<DirectorDocResult> directores);
        public bool ImportAsync(ImportFileRequest request);
    }
}
