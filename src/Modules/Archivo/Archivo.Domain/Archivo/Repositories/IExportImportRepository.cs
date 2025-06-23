using Archivo.Domain.Archivo.Parameters;
using Archivo.Domain.Archivo.Results;

namespace Archivo.Domain.Archivo.Repositories
{
    public interface IExportImportRepository
    {
        public Task<List<EmpresaDocResult>> GetEmpresas(ExportParameters request);
        public Task<List<DirectorDocResult>> GetDirectores(ExportParameters request);
    }
}
