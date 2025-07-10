/*****
 * Nombre de clase:     ObtenerRubroPorIdUseCase
 * Descripción:         Caso de uso para obtener un rubro por su identificador.
 *                      Interactúa con el repositorio de rubros para recuperar los datos.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada con lógica para manejar el caso donde no se encuentra el rubro.
 *****/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Rubro.Repositories;
using Empresa.Domain.Rubro.Results;

namespace Empresa.Application.Rubro.UseCases
{
    public class ObtenerRubroPorIdUseCase : IUseCase<int, RubroResult?>
    {
        private readonly IRubroRepository _repository;

        public ObtenerRubroPorIdUseCase(IRubroRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, RubroResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
