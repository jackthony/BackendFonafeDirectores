/***********
* Nombre del archivo: ObtenerUserPorIdUseCase.cs
* Descripción:        Caso de uso para obtener un usuario por su identificador.
*                     Orquesta la lógica para recuperar los datos de un usuario específico
*                     desde el repositorio y manejar posibles escenarios de no encontrado.
* Autor:              Daniel Alva
* Fecha de creación:  09/07/2025
* Última modificación:09/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso.
***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Usuario.Domain.User.Repositories;
using Usuario.Domain.User.Results;

namespace Usuario.Application.User.UseCases
{
    public class ObtenerUserPorIdUseCase : IUseCase<int, UserResult?>
    {
        private readonly IUserRepository _repository;

        public ObtenerUserPorIdUseCase(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, UserResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
