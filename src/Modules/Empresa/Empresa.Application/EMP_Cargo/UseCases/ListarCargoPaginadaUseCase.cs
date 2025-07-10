/*****
 * Nombre del archivo:  ListarCargoPaginadaUseCase.cs
 * Descripción:         Caso de uso para listar los cargos de forma paginada en el sistema. 
 *                      Utiliza el repositorio `ICargoRepository` y el mapeador `IMapper` para convertir la solicitud `ListarCargoPaginadoRequest` en los parámetros adecuados (`ListarCargoPaginadoParameters`).
 *                      Ejecuta la operación de listado paginado en el repositorio y devuelve los resultados de la consulta.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Cargo.Dtos;
using Empresa.Domain.Cargo.Parameters;
using Empresa.Domain.Cargo.Repositories;
using Empresa.Domain.Cargo.Results;

namespace Empresa.Application.Cargo.UseCases
{
    public class ListarCargoPaginadaUseCase : IUseCase<ListarCargoPaginadoRequest, PagedResult<CargoResult>>
    {
        private readonly ICargoRepository _repository;
        private readonly IMapper<ListarCargoPaginadoRequest, ListarCargoPaginadoParameters> _mapper;

        public ListarCargoPaginadaUseCase(
            ICargoRepository repository,
            IMapper<ListarCargoPaginadoRequest, ListarCargoPaginadoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, PagedResult<CargoResult>>> ExecuteAsync(ListarCargoPaginadoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListByPaginationAsync(parameters);
            return result;
        }
    }
}
