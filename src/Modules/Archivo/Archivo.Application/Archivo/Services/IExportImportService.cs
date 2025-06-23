using Archivo.Application.Archivo.Dtos;

namespace Archivo.Application.Archivo.Services
{
    public interface IExportImportService
    {
        Task<bool> ImportAsync(ImportFileRequest request);
        Task<Stream> ExportAsync(ExportFileRequest request);
    }
}
