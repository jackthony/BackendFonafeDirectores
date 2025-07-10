/***********
 * Nombre del archivo:  IModuloRepository.cs
 * Descripción:         Interfaz que define las operaciones para el repositorio de módulos.
 *                      Incluye métodos para agregar, actualizar, eliminar, listar y obtener módulos,
 *                      así como para listar módulos junto con sus acciones asociadas por rol.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial con todos los métodos CRUD y consulta específica para módulos con acciones.
 ***********/

using Shared.Kernel.Responses;
using Usuario.Domain.Modulo.Parameters;
using Usuario.Domain.Modulo.Results;

namespace Usuario.Domain.Modulo.Repositories
{
    public interface IModuloRepository
    {
        public Task<SpResultBase> AddAsync(CrearModuloParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarModuloParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarModuloParameters request);
        public Task<List<ModuloResult>> ListAsync(ListarModuloParameters request);
        public Task<ModuloResult?> GetByIdAsync(int id);
        public Task<PagedResult<ModuloResult>> ListByPaginationAsync(ListarModuloPaginadoParameters request);
        public Task<List<ModuloConAccionesResult>> ListModulosWithAccionsAsync(int rolId);
    }
}
