/*****
 * Nombre del archivo:  EliminarCargoUseCase.cs
 * Descripción:         Caso de uso para eliminar un cargo en el sistema. 
 *                      Utiliza el repositorio `ICargoRepository` y el mapeador `IMapper` para convertir la solicitud `EliminarCargoRequest` en parámetros adecuados (`EliminarCargoParameters`).
 *                      Ejecuta la operación de eliminación en el repositorio y maneja los errores de la base de datos si la eliminación falla.
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

namespace Empresa.Application.Cargo.UseCases
{
    public class EliminarCargoUseCase : IUseCase<EliminarCargoRequest, SpResultBase>
    {
        private readonly ICargoRepository _repository;
        private readonly IMapper<EliminarCargoRequest, EliminarCargoParameters> _mapper;

        public EliminarCargoUseCase(
            ICargoRepository repository,
            IMapper<EliminarCargoRequest, EliminarCargoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarCargoRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.DeleteAsync(parameters);

            if (!result.Success) return ErrorBase.Database(result.Message);

            return result;
        }
    }
}
