/*****
 * Nombre de clase:     ListarMinisterioPaginadaUseCase
 * Descripción:         Caso de uso encargado de listar ministerios con soporte de paginación,
 *                      utilizando filtros definidos en el DTO ListarMinisterioPaginadoRequest.
 *                      El DTO es transformado a parámetros de dominio mediante un mapper y luego
 *                      se consulta el repositorio.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para implementar la lógica de listado paginado de ministerios.
 *****/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Ministerio.Dtos;
using Empresa.Domain.Ministerio.Parameters;
using Empresa.Domain.Ministerio.Repositories;
using Empresa.Domain.Ministerio.Results;

namespace Empresa.Application.Ministerio.UseCases
{
    public class ListarMinisterioPaginadaUseCase : IUseCase<ListarMinisterioPaginadoRequest, PagedResult<MinisterioResult>>
    {
        private readonly IMinisterioRepository _repository;
        private readonly IMapper<ListarMinisterioPaginadoRequest, ListarMinisterioPaginadoParameters> _mapper;

        public ListarMinisterioPaginadaUseCase(
            IMinisterioRepository repository,
            IMapper<ListarMinisterioPaginadoRequest, ListarMinisterioPaginadoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, PagedResult<MinisterioResult>>> ExecuteAsync(ListarMinisterioPaginadoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListByPaginationAsync(parameters);
            return result;
        }
    }
}
