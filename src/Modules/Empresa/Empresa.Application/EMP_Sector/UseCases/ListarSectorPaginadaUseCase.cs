/*****
 * Nombre del archivo:  ListarSectorPaginadaUseCase.cs
 * Descripción:         Caso de uso para listar sectores con paginación y filtros opcionales.
 *                      Realiza el mapeo de la solicitud paginada a parámetros del dominio y consulta
 *                      el repositorio para obtener resultados paginados.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Sector.Dtos;
using Empresa.Domain.Sector.Parameters;
using Empresa.Domain.Sector.Repositories;
using Empresa.Domain.Sector.Results;

namespace Empresa.Application.Sector.UseCases
{
    public class ListarSectorPaginadaUseCase : IUseCase<ListarSectorPaginadoRequest, PagedResult<SectorResult>>
    {
        private readonly ISectorRepository _repository;
        private readonly IMapper<ListarSectorPaginadoRequest, ListarSectorPaginadoParameters> _mapper;

        public ListarSectorPaginadaUseCase(
            ISectorRepository repository,
            IMapper<ListarSectorPaginadoRequest, ListarSectorPaginadoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, PagedResult<SectorResult>>> ExecuteAsync(ListarSectorPaginadoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListByPaginationAsync(parameters);
            return result;
        }
    }
}
