/*****
 * Nombre de clase:     ObtenerEspecialidadPorIdUseCase
 * Descripción:         Caso de uso para obtener una especialidad por su Id.
 *                      Se encarga de invocar el repositorio para buscar la especialidad y
 *                      retorna el resultado o un error si no se encuentra.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase implementada para la obtención de especialidades por Id.
 *****/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Especialidad.Repositories;
using Empresa.Domain.Especialidad.Results;

namespace Empresa.Application.Especialidad.UseCases
{
    public class ObtenerEspecialidadPorIdUseCase : IUseCase<int, EspecialidadResult?>
    {
        private readonly IEspecialidadRepository _repository;

        public ObtenerEspecialidadPorIdUseCase(IEspecialidadRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, EspecialidadResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
