/***********
 * Nombre del archivo:  IUserRepository.cs
 * Descripción:         Interfaz para el repositorio de usuarios. Define los contratos para operaciones
 *                      CRUD, listado simple y paginado, y obtención por ID de los usuarios del sistema.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la interfaz para operaciones básicas sobre usuarios.
 ***********/

using Shared.Kernel.Responses;
using Usuario.Domain.User.Parameters;
using Usuario.Domain.User.Results;

namespace Usuario.Domain.User.Repositories
{
    public interface IUserRepository
    {
        public Task<SpResultBase> AddAsync(CrearUserParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarUserParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarUserParameters request);
        public Task<List<UserResult>> ListAsync(ListarUserParameters request);
        public Task<UserResult?> GetByIdAsync(int id);
        public Task<PagedResult<UserResult>> ListByPaginationAsync(ListarUserPaginadoParameters request);
    }
}
