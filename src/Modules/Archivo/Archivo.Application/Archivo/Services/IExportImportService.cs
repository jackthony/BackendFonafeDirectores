using Archivo.Application.Archivo.Dtos;
using Archivo.Domain.Archivo.Results;

namespace Archivo.Application.Archivo.Services
{
    public interface IExportImportService
    {
        public Stream ObtenerDatosExportAsync(List<EmpresaDocResult> empresas, List<DirectorDocResult> directores, int tipo);
        public ImportFileResult ImportAsync(ImportFileRequest request);
    }
}
