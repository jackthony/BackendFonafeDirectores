/***********
* Nombre del archivo: ObtenerRolPorIdUseCase.cs
* Descripción:        Caso de uso para obtener un rol por su identificador.
*                     Orquesta la lógica para recuperar los datos de un rol específico
*                     desde el repositorio y manejar posibles escenarios de no encontrado.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso.
***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Usuario.Domain.Rol.Repositories;
using Usuario.Domain.Rol.Results;

namespace Usuario.Application.Rol.UseCases
{
    public class ObtenerRolPorIdUseCase : IUseCase<int, RolResult?>
    {
        private readonly IRolRepository _repository;

        public ObtenerRolPorIdUseCase(IRolRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, RolResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
