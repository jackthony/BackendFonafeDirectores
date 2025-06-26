using Archivo.Domain.Archivo.Parameters;
using Archivo.Domain.Archivo.Results;
using Empresa.Domain.Director.Parameters;
using Empresa.Domain.Empresa.Parameters;

namespace Archivo.Domain.Archivo.Repositories
{
    public interface IExportImportRepository
    {
        public Task<List<EmpresaDocResult>> GetEmpresas(ExportParameters request);
        public Task<List<DirectorDocResult>> GetDirectores(ExportParameters request);
        public Task InsertEmpresasAsync(List<CrearEmpresaParameters> empresas);
        public Task InsertDirectoresAsync(List<CrearDirectorParameters> directores);
    }
}
