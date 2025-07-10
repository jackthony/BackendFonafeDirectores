/*****
 * Nombre de clase:     ActualizarRubroUseCase
 * Descripción:         Caso de uso encargado de actualizar un rubro existente en el sistema.
 *                      Mapea el DTO recibido a los parámetros de dominio y ejecuta la operación de actualización.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para manejar la lógica de actualización de rubros.
 *****/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Rubro.Dtos;
using Empresa.Domain.Rubro.Parameters;
using Empresa.Domain.Rubro.Repositories;

namespace Empresa.Application.Rubro.UseCases
{
    public class ActualizarRubroUseCase : IUseCase<ActualizarRubroRequest, SpResultBase>
    {
        private readonly IRubroRepository _repository;
        private readonly IMapper<ActualizarRubroRequest, ActualizarRubroParameters> _mapper;

        public ActualizarRubroUseCase(IRubroRepository repository, IMapper<ActualizarRubroRequest, ActualizarRubroParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarRubroRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.UpdateAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
