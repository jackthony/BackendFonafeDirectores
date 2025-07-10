/*****
 * Nombre del archivo:  ObtenerTipoDirectorPorIdUseCase.cs
 * Descripción:         Caso de uso para obtener un tipo de director por su ID. Consulta el repositorio
 *                      y retorna el resultado o un error en caso de no encontrarse.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Domain.TipoDirector.Repositories;
using Empresa.Domain.TipoDirector.Results;

namespace Empresa.Application.TipoDirector.UseCases
{
    public class ObtenerTipoDirectorPorIdUseCase : IUseCase<int, TipoDirectorResult?>
    {
        private readonly ITipoDirectorRepository _repository;

        public ObtenerTipoDirectorPorIdUseCase(ITipoDirectorRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, TipoDirectorResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
