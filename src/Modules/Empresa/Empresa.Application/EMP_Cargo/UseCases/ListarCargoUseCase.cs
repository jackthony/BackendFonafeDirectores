/*****
 * Nombre del archivo:  ListarCargoUseCase.cs
 * Descripción:         Caso de uso para listar los cargos en el sistema. 
 *                      Utiliza el repositorio `ICargoRepository` y el mapeador `IMapper` para convertir la solicitud `ListarCargoRequest` en los parámetros adecuados (`ListarCargoParameters`).
 *                      Ejecuta la operación de listado en el repositorio y devuelve los resultados de la consulta.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
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
    public class ListarCargoUseCase : IUseCase<ListarCargoRequest, List<CargoResult>>
    {
        private readonly ICargoRepository _repository;
        private readonly IMapper<ListarCargoRequest, ListarCargoParameters> _mapper;

        public ListarCargoUseCase(
            ICargoRepository repository,
            IMapper<ListarCargoRequest, ListarCargoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<CargoResult>>> ExecuteAsync(ListarCargoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListAsync(parameters);
            return result;
        }
    }
}
