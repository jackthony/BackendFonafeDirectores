/***********
 * Nombre del archivo:  IRolRepository.cs
 * Descripción:         Interfaz que define las operaciones del repositorio para la entidad Rol.
 *                      Incluye métodos para crear, actualizar, eliminar, listar, paginar y asignar permisos a roles.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Definición inicial de operaciones para la gestión de roles y sus permisos.
 ***********/

using Shared.Kernel.Responses;
using Usuario.Domain.Rol.Parameters;
using Usuario.Domain.Rol.Results;
using Usuario.Domain.SEG_Rol.Parameters;

namespace Usuario.Domain.Rol.Repositories
{
    public interface IRolRepository
    {
        public Task<SpResultBase> AddAsync(CrearRolParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarRolParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarRolParameters request);
        public Task<List<RolResult>> ListAsync(ListarRolParameters request);
        public Task<RolResult?> GetByIdAsync(int id);
        public Task<PagedResult<RolResult>> ListByPaginationAsync(ListarRolPaginadoParameters request);
        public Task<SpResultBase> AddPermisosRolesAsync(CrearPermisosRolParameters request);
    }
}
