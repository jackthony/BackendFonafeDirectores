/*****
 * Nombre de clase:     ListarEspecialidadPaginadaUseCase
 * Descripción:         Caso de uso para listar especialidades con paginación, aplicando
 *                      los parámetros paginados recibidos para obtener resultados segmentados.
 *                      Mapea la solicitud a parámetros de dominio y llama al repositorio para obtener
 *                      un resultado paginado.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para gestionar la obtención paginada de especialidades.
 *****/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Especialidad.Dtos;
using Empresa.Domain.Especialidad.Parameters;
using Empresa.Domain.Especialidad.Repositories;
using Empresa.Domain.Especialidad.Results;

namespace Empresa.Application.Especialidad.UseCases
{
    public class ListarEspecialidadPaginadaUseCase : IUseCase<ListarEspecialidadPaginadoRequest, PagedResult<EspecialidadResult>>
    {
        private readonly IEspecialidadRepository _repository;
        private readonly IMapper<ListarEspecialidadPaginadoRequest, ListarEspecialidadPaginadoParameters> _mapper;

        public ListarEspecialidadPaginadaUseCase(
            IEspecialidadRepository repository,
            IMapper<ListarEspecialidadPaginadoRequest, ListarEspecialidadPaginadoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, PagedResult<EspecialidadResult>>> ExecuteAsync(ListarEspecialidadPaginadoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListByPaginationAsync(parameters);
            return result;
        }
    }
}
