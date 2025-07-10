/***********
* Nombre del archivo: ActualizarUserUseCase.cs
* Descripción:        Caso de uso para la actualización de un usuario existente.
*                     Orquesta el proceso de actualizar la información de un usuario, transformando
*                     la solicitud a parámetros de dominio y utilizando el repositorio para ejecutar
*                     la operación de actualización.
* Autor:              Daniel Alva
* Fecha de creación:  10/07/2025
* Última modificación:10/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para actualizar un usuario.
***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.User.Dtos;
using Usuario.Domain.User.Parameters;
using Usuario.Domain.User.Repositories;

namespace Usuario.Application.User.UseCases
{
    public class ActualizarUserUseCase : IUseCase<ActualizarUserRequest, SpResultBase>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper<ActualizarUserRequest, ActualizarUserParameters> _mapper;

        public ActualizarUserUseCase(IUserRepository repository, IMapper<ActualizarUserRequest, ActualizarUserParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarUserRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.UpdateAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
