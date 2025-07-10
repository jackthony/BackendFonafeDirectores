/*****
 * Nombre del archivo:  IArchivoRepository.cs
 * Descripción:         Interfaz que define los métodos para interactuar con los datos de archivos en el repositorio. 
 *                      Incluye operaciones como agregar, actualizar, eliminar, listar y obtener archivos por ID, así como obtener archivos con paginación.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la interfaz.
 *****/
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
