/*****
 * Nombre del archivo:  ObtenerCargoPorIdUseCase.cs
 * Descripción:         Caso de uso para obtener un cargo por su ID en el sistema. 
 *                      Utiliza el repositorio `ICargoRepository` para consultar el cargo correspondiente y devuelve el resultado o un error si no se encuentra el cargo.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Cargo.Repositories;
using Empresa.Domain.Cargo.Results;

namespace Empresa.Application.Cargo.UseCases
{
    public class ObtenerCargoPorIdUseCase : IUseCase<int, CargoResult?>
    {
        private readonly ICargoRepository _repository;

        public ObtenerCargoPorIdUseCase(ICargoRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, CargoResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
