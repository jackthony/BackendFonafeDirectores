/*****
 * Nombre del archivo:  ListarTipoDirectorPaginadaUseCase.cs
 * Descripción:         Caso de uso para listar tipos de director de forma paginada. Mapea la solicitud
 *                      a parámetros de dominio y utiliza el repositorio para obtener un resultado paginado.
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
using Empresa.Domain.TipoDirector.Results;

namespace Empresa.Application.TipoDirector.UseCases
{
    public class ListarTipoDirectorPaginadaUseCase : IUseCase<ListarTipoDirectorPaginadoRequest, PagedResult<TipoDirectorResult>>
    {
        private readonly ITipoDirectorRepository _repository;
        private readonly IMapper<ListarTipoDirectorPaginadoRequest, ListarTipoDirectorPaginadoParameters> _mapper;

        public ListarTipoDirectorPaginadaUseCase(
            ITipoDirectorRepository repository,
            IMapper<ListarTipoDirectorPaginadoRequest, ListarTipoDirectorPaginadoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, PagedResult<TipoDirectorResult>>> ExecuteAsync(ListarTipoDirectorPaginadoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListByPaginationAsync(parameters);
            return result;
        }
    }
}
