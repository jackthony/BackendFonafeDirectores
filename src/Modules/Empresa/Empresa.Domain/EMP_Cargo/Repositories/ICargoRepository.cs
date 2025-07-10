/***********
 * Nombre del archivo:  ICargoRepository.cs
 * Descripción:         Interfaz que define los métodos para el acceso y manipulación
 *                      de datos relacionados con cargos, incluyendo operaciones CRUD
 *                      y listados con paginación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación de la interfaz para el repositorio de cargos.
 ***********/

using Shared.Kernel.Responses;
using Empresa.Domain.Cargo.Parameters;
using Empresa.Domain.Cargo.Results;

namespace Empresa.Domain.Cargo.Repositories
{
    public interface ICargoRepository
    {
        public Task<SpResultBase> AddAsync(CrearCargoParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarCargoParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarCargoParameters request);
        public Task<List<CargoResult>> ListAsync(ListarCargoParameters request);
        public Task<CargoResult?> GetByIdAsync(int id);
        public Task<PagedResult<CargoResult>> ListByPaginationAsync(ListarCargoPaginadoParameters request);
    }
}
