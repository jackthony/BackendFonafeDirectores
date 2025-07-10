/***********
* Nombre del archivo: ListarUserUseCase.cs
* Descripción:        Caso de uso para listar usuarios sin paginación.
*                     Coordina la obtención de una colección de usuarios basándose en los parámetros
*                     de solicitud, utilizando un mapper para transformar la petición y un repositorio
*                     para acceder a los datos.
* Autor:              Daniel Alva
* Fecha de creación:  09/07/2025
* Última modificación:09/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para listar usuarios.
***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.User.Dtos;
using Usuario.Domain.User.Parameters;
using Usuario.Domain.User.Repositories;
using Usuario.Domain.User.Results;

namespace Usuario.Application.User.UseCases
{
    public class ListarUserUseCase : IUseCase<ListarUserRequest, List<UserResult>>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper<ListarUserRequest, ListarUserParameters> _mapper;

        public ListarUserUseCase(
            IUserRepository repository,
            IMapper<ListarUserRequest, ListarUserParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<UserResult>>> ExecuteAsync(ListarUserRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListAsync(parameters);
            return result;
        }
    }
}
