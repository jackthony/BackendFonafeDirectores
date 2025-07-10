/***********
 * Nombre del archivo:  IEmpresaRepository.cs
 * Descripción:         Interfaz que define los contratos para el repositorio de la entidad Empresa.
 *                      Contempla operaciones CRUD, consulta por ID, listado y paginación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Interfaz creada para abstraer las operaciones de acceso a datos de Empresa.
 ***********/

using Shared.Kernel.Responses;
using Empresa.Domain.Empresa.Parameters;
using Empresa.Domain.Empresa.Results;

namespace Empresa.Domain.Empresa.Repositories
{
    public interface IEmpresaRepository
    {
        public Task<SpResultBase> AddAsync(CrearEmpresaParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarEmpresaParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarEmpresaParameters request);
        public Task<List<EmpresaResult>> ListAsync(ListarEmpresaParameters request);
        public Task<EmpresaResult?> GetByIdAsync(int id);
        public Task<PagedResult<EmpresaResult>> ListByPaginationAsync(ListarEmpresaPaginadoParameters request);
    }
}
