/*****
 * Nombre del archivo:  CrearCargoUseCase.cs
 * Descripción:         Caso de uso para crear un nuevo cargo en el sistema. 
 *                      Utiliza el repositorio `ICargoRepository` y el mapeador `IMapper` para convertir la solicitud `CrearCargoRequest` en parámetros adecuados (`CrearCargoParameters`).
 *                      Ejecuta la operación de creación en el repositorio y maneja los errores de la base de datos si la creación falla.
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

namespace Empresa.Application.Cargo.UseCases
{
    public class CrearCargoUseCase : IUseCase<CrearCargoRequest, SpResultBase>
    {
        private readonly ICargoRepository _repository;
        private readonly IMapper<CrearCargoRequest, CrearCargoParameters> _mapper;

        public CrearCargoUseCase(ICargoRepository repository, IMapper<CrearCargoRequest, CrearCargoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearCargoRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
