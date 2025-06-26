using Shared.Kernel.Responses;
using Archivo.Domain.Archivo.Parameters;
using Archivo.Domain.Archivo.Results;

namespace Archivo.Domain.Archivo.Repositories
{
    public interface IArchivoRepository
    {
        public Task<SpResultBase> AddAsync(CrearArchivoParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarArchivoParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarArchivoParameters request);
        public Task<List<ArchivoResult>> ListAsync(ListarArchivoParameters request);
        public Task<ArchivoResult?> GetByIdAsync(int id);
        public Task<PagedResult<ArchivoResult>> ListByPaginationAsync(ListarArchivoPaginadoParameters request);
    }
}
