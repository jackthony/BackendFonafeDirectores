/***********
* Nombre del archivo: ListarModulosConAccionesUseCase.cs
* Descripción:        **Caso de uso** para listar módulos junto con sus acciones asociadas para un rol específico.
*                     Orquesta la lógica para recuperar los datos de los módulos y sus acciones
*                     desde el **repositorio**, permitiendo obtener una visión completa de los permisos
*                     configurados para un determinado rol.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para listar módulos con acciones.
***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Usuario.Domain.Modulo.Repositories;
using Usuario.Domain.Modulo.Results;

namespace Usuario.Application.Modulo.UseCases
{
    public class ListarModulosConAccionesUseCase : IUseCase<int, List<ModuloConAccionesResult>>
    {
        private readonly IModuloRepository _repository;

        public ListarModulosConAccionesUseCase(IModuloRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, List<ModuloConAccionesResult>>> ExecuteAsync(int rolId)
        {
            var result = await _repository.ListModulosWithAccionsAsync(rolId);
            return result;
        }
    }
}
