/***********
* Nombre del archivo: ObtenerPermisoRolPorIdUseCase.cs
* Descripción:        **Caso de uso** para obtener un permiso de rol por su identificador.
*                     Orquesta la lógica para recuperar los datos de un permiso de rol específico
*                     desde el **repositorio** y manejar posibles escenarios donde el permiso no es encontrado.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso.
***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Usuario.Domain.PermisoRol.Repositories;
using Usuario.Domain.PermisoRol.Results;

namespace Usuario.Application.PermisoRol.UseCases
{
    public class ObtenerPermisoRolPorIdUseCase : IUseCase<int, PermisoRolResult?>
    {
        private readonly IPermisoRolRepository _repository;

        public ObtenerPermisoRolPorIdUseCase(IPermisoRolRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, PermisoRolResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
