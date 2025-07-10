/*****
 * Nombre del archivo:  ActualizarCargoUseCase.cs
 * Descripción:         Caso de uso para actualizar un cargo en el sistema. 
 *                      Utiliza el repositorio `ICargoRepository` y el mapeador `IMapper` para convertir la solicitud `ActualizarCargoRequest` en parámetros adecuados (`ActualizarCargoParameters`).
 *                      Ejecuta la operación de actualización en el repositorio y maneja los errores de la base de datos si la actualización falla.
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
    public class ActualizarCargoUseCase : IUseCase<ActualizarCargoRequest, SpResultBase>
    {
        private readonly ICargoRepository _repository;
        private readonly IMapper<ActualizarCargoRequest, ActualizarCargoParameters> _mapper;

        public ActualizarCargoUseCase(ICargoRepository repository, IMapper<ActualizarCargoRequest, ActualizarCargoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarCargoRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.UpdateAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
