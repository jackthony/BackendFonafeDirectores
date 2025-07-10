/***********
 * Nombre del archivo:  IPermisoRolRepository.cs
 * Descripción:         Interfaz que define los métodos para
 *                      manejar permisos asociados a roles,
 *                      incluyendo operaciones CRUD y listados con
 *                      o sin paginación.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Definición inicial de la interfaz.
 ***********/

using Shared.Kernel.Responses;
using Usuario.Domain.PermisoRol.Parameters;
using Usuario.Domain.PermisoRol.Results;

namespace Usuario.Domain.PermisoRol.Repositories
{
    public interface IPermisoRolRepository
    {
        public Task<SpResultBase> AddAsync(CrearPermisoRolParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarPermisoRolParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarPermisoRolParameters request);
        public Task<List<PermisoRolResult>> ListAsync(ListarPermisoRolParameters request);
        public Task<PermisoRolResult?> GetByIdAsync(int id);
        public Task<PagedResult<PermisoRolResult>> ListByPaginationAsync(ListarPermisoRolPaginadoParameters request);
    }
}
