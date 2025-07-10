/***********
 * Nombre del archivo:  IDirectorRepository.cs
 * Descripción:         Interfaz que define los métodos para el acceso y manipulación
 *                      de datos de directores asociados a empresas, incluyendo operaciones CRUD,
 *                      listados con paginación y consulta de número de miembros.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación de la interfaz para el repositorio de directores.
 ***********/

using Shared.Kernel.Responses;
using Empresa.Domain.Director.Parameters;
using Empresa.Domain.Director.Results;

namespace Empresa.Domain.Director.Repositories
{
    public interface IDirectorRepository
    {
        public Task<SpResultBase> AddAsync(CrearDirectorParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarDirectorParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarDirectorParameters request);
        public Task<List<DirectorResult>> ListAsync(ListarDirectorParameters request);
        public Task<DirectorResult?> GetByIdAsync(int id);
        public Task<PagedResult<DirectorResult>> ListByPaginationAsync(ListarDirectorPaginadoParameters request);
        public Task<int> GetNumeroMiembros(int empresaId);
    }
}
