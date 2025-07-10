/***********
 * Nombre del archivo:  ITipoDirectorRepository.cs
 * Descripción:         Interfaz del repositorio para el módulo TipoDirector. Define los contratos
 *                      para operaciones CRUD, obtención por ID y paginación, utilizando parámetros y DTOs asociados.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la interfaz ITipoDirectorRepository.
 ***********/

using Shared.Kernel.Responses;
using Empresa.Domain.TipoDirector.Parameters;
using Empresa.Domain.TipoDirector.Results;

namespace Empresa.Domain.TipoDirector.Repositories
{
    public interface ITipoDirectorRepository
    {
        public Task<SpResultBase> AddAsync(CrearTipoDirectorParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarTipoDirectorParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarTipoDirectorParameters request);
        public Task<List<TipoDirectorResult>> ListAsync(ListarTipoDirectorParameters request);
        public Task<TipoDirectorResult?> GetByIdAsync(int id);
        public Task<PagedResult<TipoDirectorResult>> ListByPaginationAsync(ListarTipoDirectorPaginadoParameters request);
    }
}
