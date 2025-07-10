/***********
* Nombre del archivo: ListarRolPaginadaUseCase.cs
* Descripción:        Caso de uso para listar roles con paginación.
*                     Orquesta la lógica para obtener una colección paginada de roles,
*                     transformando la solicitud a parámetros de dominio y utilizando el repositorio
*                     para acceder a los datos.
* Autor:              Daniel Alva
* Fecha de creación:  10/07/2025
* Última modificación:10/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para listar roles paginados.
***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.Rol.Dtos;
using Usuario.Domain.Rol.Parameters;
using Usuario.Domain.Rol.Repositories;
using Usuario.Domain.Rol.Results;

namespace Usuario.Application.Rol.UseCases
{
    public class ListarRolPaginadaUseCase : IUseCase<ListarRolPaginadoRequest, PagedResult<RolResult>>
    {
        private readonly IRolRepository _repository;
        private readonly IMapper<ListarRolPaginadoRequest, ListarRolPaginadoParameters> _mapper;

        public ListarRolPaginadaUseCase(
            IRolRepository repository,
            IMapper<ListarRolPaginadoRequest, ListarRolPaginadoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, PagedResult<RolResult>>> ExecuteAsync(ListarRolPaginadoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListByPaginationAsync(parameters);
            return result;
        }
    }
}
