/***********
* Nombre del archivo: ObtenerModuloPorIdUseCase.cs
* Descripción:        **Caso de uso** para obtener un módulo por su identificador.
*                     Orquesta la lógica para recuperar los datos de un módulo específico
*                     desde el **repositorio** y manejar posibles escenarios donde el módulo no es encontrado.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso.
***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Usuario.Domain.Modulo.Repositories;
using Usuario.Domain.Modulo.Results;

namespace Usuario.Application.Modulo.UseCases
{
    public class ObtenerModuloPorIdUseCase : IUseCase<int, ModuloResult?>
    {
        private readonly IModuloRepository _repository;

        public ObtenerModuloPorIdUseCase(IModuloRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, ModuloResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
