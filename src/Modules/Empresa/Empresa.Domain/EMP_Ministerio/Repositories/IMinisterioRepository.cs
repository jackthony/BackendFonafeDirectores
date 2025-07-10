/***********
 * Nombre del archivo:  IMinisterioRepository.cs
 * Descripción:         Interfaz que define los contratos para las operaciones de acceso a datos de la entidad Ministerio,
 *                      incluyendo métodos para registrar, actualizar, eliminar, listar, paginar y obtener por ID.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Definición inicial de interfaz para el repositorio de Ministerio.
 ***********/

using Shared.Kernel.Responses;
using Empresa.Domain.Ministerio.Parameters;
using Empresa.Domain.Ministerio.Results;

namespace Empresa.Domain.Ministerio.Repositories
{
    public interface IMinisterioRepository
    {
        public Task<SpResultBase> AddAsync(CrearMinisterioParameters request);
        public Task<SpResultBase> UpdateAsync(ActualizarMinisterioParameters request);
        public Task<SpResultBase> DeleteAsync(EliminarMinisterioParameters request);
        public Task<List<MinisterioResult>> ListAsync(ListarMinisterioParameters request);
        public Task<MinisterioResult?> GetByIdAsync(int id);
        public Task<PagedResult<MinisterioResult>> ListByPaginationAsync(ListarMinisterioPaginadoParameters request);
    }
}
