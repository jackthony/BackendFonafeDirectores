/*****
 * Nombre del archivo:  ActualizarTipoDirectorUseCase.cs
 * Descripción:         Caso de uso para actualizar un tipo de director. Mapea la solicitud a parámetros de dominio,
 *                      ejecuta la operación en el repositorio y retorna el resultado o un error en caso de falla.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.TipoDirector.Dtos;
using Empresa.Domain.TipoDirector.Parameters;
using Empresa.Domain.TipoDirector.Repositories;

namespace Empresa.Application.TipoDirector.UseCases
{
    public class ActualizarTipoDirectorUseCase : IUseCase<ActualizarTipoDirectorRequest, SpResultBase>
    {
        private readonly ITipoDirectorRepository _repository;
        private readonly IMapper<ActualizarTipoDirectorRequest, ActualizarTipoDirectorParameters> _mapper;

        public ActualizarTipoDirectorUseCase(ITipoDirectorRepository repository, IMapper<ActualizarTipoDirectorRequest, ActualizarTipoDirectorParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarTipoDirectorRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.UpdateAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
