/*****
 * Nombre de clase:     EliminarRubroUseCase
 * Descripción:         Caso de uso encargado de eliminar un rubro en base a los parámetros enviados.
 *                      Aplica mapeo del DTO a parámetros de dominio y ejecuta la operación en el repositorio.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para manejar la lógica de eliminación de rubros.
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
    public class EliminarRubroUseCase : IUseCase<EliminarRubroRequest, SpResultBase>
    {
        private readonly IRubroRepository _repository;
        private readonly IMapper<EliminarRubroRequest, EliminarRubroParameters> _mapper;

        public EliminarRubroUseCase(
            IRubroRepository repository,
            IMapper<EliminarRubroRequest, EliminarRubroParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarRubroRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.DeleteAsync(parameters);

            if (!result.Success) return ErrorBase.Database(result.Message);

            return result;
        }
    }
}
