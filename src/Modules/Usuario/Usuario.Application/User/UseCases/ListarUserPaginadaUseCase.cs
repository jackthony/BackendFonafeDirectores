/***********
* Nombre del archivo: ListarUserPaginadaUseCase.cs
* Descripción:        Caso de uso para listar usuarios con paginación.
*                     Orquesta la lógica para obtener una colección paginada de usuarios,
*                     transformando la solicitud a parámetros de dominio y utilizando el repositorio
*                     para acceder a los datos.
* Autor:              Daniel Alva
* Fecha de creación:  09/07/2025
* Última modificación:09/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para listar usuarios paginados.
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
    public class ListarUserPaginadaUseCase : IUseCase<ListarUserPaginadoRequest, PagedResult<UserResult>>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper<ListarUserPaginadoRequest, ListarUserPaginadoParameters> _mapper;

        public ListarUserPaginadaUseCase(
            IUserRepository repository,
            IMapper<ListarUserPaginadoRequest, ListarUserPaginadoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, PagedResult<UserResult>>> ExecuteAsync(ListarUserPaginadoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListByPaginationAsync(parameters);
            return result;
        }
    }
}
