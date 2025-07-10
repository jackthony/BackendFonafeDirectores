/***********
 * Nombre del archivo:  IEspecialidadRepository.cs
 * Descripción:         Interfaz que define los métodos del repositorio para la entidad Especialidad,
 *                      incluyendo operaciones CRUD y listados con o sin paginación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Interfaz creada para manejar persistencia de datos de especialidades.
 ***********/

using Shared.Kernel.Responses;
using Empresa.Domain.Especialidad.Parameters;
using Empresa.Domain.Especialidad.Results;

namespace Empresa.Domain.Especialidad.Repositories
{
    public interface IEspecialidadRepository
    {
        public Task<SpResultBase> AddAsync(CrearEspecialidadParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarEspecialidadParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarEspecialidadParameters request);
        public Task<List<EspecialidadResult>> ListAsync(ListarEspecialidadParameters request);
        public Task<EspecialidadResult?> GetByIdAsync(int id);
        public Task<PagedResult<EspecialidadResult>> ListByPaginationAsync(ListarEspecialidadPaginadoParameters request);
    }
}
