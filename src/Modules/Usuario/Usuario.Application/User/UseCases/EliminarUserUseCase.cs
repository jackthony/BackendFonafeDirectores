/***********
* Nombre del archivo: EliminarUserUseCase.cs
* Descripción:        Caso de uso para la eliminación de un usuario.
*                     Orquesta el proceso de eliminar un usuario, transformando la solicitud
*                     a parámetros de dominio y utilizando el repositorio para ejecutar la operación
*                     de eliminación, manejando el resultado de la misma.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para eliminar un usuario.
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
    public class EliminarUserUseCase : IUseCase<EliminarUserRequest, SpResultBase>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper<EliminarUserRequest, EliminarUserParameters> _mapper;

        public EliminarUserUseCase(
            IUserRepository repository,
            IMapper<EliminarUserRequest, EliminarUserParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarUserRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.DeleteAsync(parameters);

            if (!result.Success) return ErrorBase.Database(result.Message);

            return result;
        }
    }
}
