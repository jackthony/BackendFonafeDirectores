/***********
 * Nombre del archivo:  IRubroRepository.cs
 * Descripción:         Interfaz que define los contratos para el repositorio de rubros, incluyendo
 *                      operaciones CRUD, listado simple y listado paginado.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Definición inicial de la interfaz para el repositorio de rubros.
 ***********/

using Shared.Kernel.Responses;
using Empresa.Domain.Rubro.Parameters;
using Empresa.Domain.Rubro.Results;

namespace Empresa.Domain.Rubro.Repositories
{
    public interface IRubroRepository
    {
        public Task<SpResultBase> AddAsync(CrearRubroParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarRubroParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarRubroParameters request);
        public Task<List<RubroResult>> ListAsync(ListarRubroParameters request);
        public Task<RubroResult?> GetByIdAsync(int id);
        public Task<PagedResult<RubroResult>> ListByPaginationAsync(ListarRubroPaginadoParameters request);
    }
}
