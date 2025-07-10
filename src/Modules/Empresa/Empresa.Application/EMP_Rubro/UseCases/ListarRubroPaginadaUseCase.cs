/*****
 * Nombre de clase:     ListarRubroPaginadaUseCase
 * Descripción:         Caso de uso que permite listar rubros de forma paginada, utilizando los filtros enviados en el request.
 *                      Aplica el patrón de mapeo para convertir el DTO en parámetros de dominio y consulta el repositorio correspondiente.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase implementada para soportar listado paginado de rubros.
 *****/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Rubro.Dtos;
using Empresa.Domain.Rubro.Parameters;
using Empresa.Domain.Rubro.Repositories;
using Empresa.Domain.Rubro.Results;

namespace Empresa.Application.Rubro.UseCases
{
    public class ListarRubroPaginadaUseCase : IUseCase<ListarRubroPaginadoRequest, PagedResult<RubroResult>>
    {
        private readonly IRubroRepository _repository;
        private readonly IMapper<ListarRubroPaginadoRequest, ListarRubroPaginadoParameters> _mapper;

        public ListarRubroPaginadaUseCase(
            IRubroRepository repository,
            IMapper<ListarRubroPaginadoRequest, ListarRubroPaginadoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, PagedResult<RubroResult>>> ExecuteAsync(ListarRubroPaginadoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListByPaginationAsync(parameters);
            return result;
        }
    }
}
