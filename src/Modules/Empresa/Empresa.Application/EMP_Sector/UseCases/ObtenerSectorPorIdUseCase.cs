/*****
 * Nombre del archivo:  ObtenerSectorPorIdUseCase.cs
 * Descripción:         Caso de uso para obtener un sector por su ID. Consulta el repositorio
 *                      y retorna el resultado o un error si no se encuentra el sector.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Sector.Repositories;
using Empresa.Domain.Sector.Results;

namespace Empresa.Application.Sector.UseCases
{
    public class ObtenerSectorPorIdUseCase : IUseCase<int, SectorResult?>
    {
        private readonly ISectorRepository _repository;

        public ObtenerSectorPorIdUseCase(ISectorRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, SectorResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
