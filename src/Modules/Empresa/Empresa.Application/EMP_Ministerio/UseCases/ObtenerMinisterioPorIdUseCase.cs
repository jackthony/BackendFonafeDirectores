/*****
 * Nombre de clase:     ObtenerMinisterioPorIdUseCase
 * Descripción:         Caso de uso encargado de obtener un ministerio a partir de su ID.
 *                      Devuelve un resultado del tipo MinisterioResult o un error si no se encuentra.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para implementar la lógica de obtención de ministerio por ID.
 *****/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Ministerio.Repositories;
using Empresa.Domain.Ministerio.Results;

namespace Empresa.Application.Ministerio.UseCases
{
    public class ObtenerMinisterioPorIdUseCase : IUseCase<int, MinisterioResult?>
    {
        private readonly IMinisterioRepository _repository;

        public ObtenerMinisterioPorIdUseCase(IMinisterioRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, MinisterioResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
