/***********
 * Nombre del archivo:  ISectorRepository.cs
 * Descripción:         Interfaz del repositorio para el manejo del módulo Sector. Define los contratos
 *                      para realizar operaciones CRUD, obtener por ID y listar con paginación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la interfaz ISectorRepository.
 ***********/

using Shared.Kernel.Responses;
using Empresa.Domain.Sector.Parameters;
using Empresa.Domain.Sector.Results;

namespace Empresa.Domain.Sector.Repositories
{
    public interface ISectorRepository
    {
        public Task<SpResultBase> AddAsync(CrearSectorParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarSectorParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarSectorParameters request);
        public Task<List<SectorResult>> ListAsync(ListarSectorParameters request);
        public Task<SectorResult?> GetByIdAsync(int id);
        public Task<PagedResult<SectorResult>> ListByPaginationAsync(ListarSectorPaginadoParameters request);
    }
}
