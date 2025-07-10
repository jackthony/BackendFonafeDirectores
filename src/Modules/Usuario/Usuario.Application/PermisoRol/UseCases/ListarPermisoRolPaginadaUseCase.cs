/***********
* Nombre del archivo: ListarPermisoRolPaginadaUseCase.cs
* Descripción:        **Caso de uso** para listar permisos de rol con paginación.
*                     Orquesta la lógica para obtener una colección paginada de permisos de rol,
*                     transformando la solicitud a parámetros de dominio y utilizando el **repositorio**
*                     para acceder a los datos.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para listar permisos de rol paginados.
***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.PermisoRol.Dtos;
using Usuario.Domain.PermisoRol.Parameters;
using Usuario.Domain.PermisoRol.Repositories;
using Usuario.Domain.PermisoRol.Results;

namespace Usuario.Application.PermisoRol.UseCases
{
    public class ListarPermisoRolPaginadaUseCase : IUseCase<ListarPermisoRolPaginadoRequest, PagedResult<PermisoRolResult>>
    {
        private readonly IPermisoRolRepository _repository;
        private readonly IMapper<ListarPermisoRolPaginadoRequest, ListarPermisoRolPaginadoParameters> _mapper;

        public ListarPermisoRolPaginadaUseCase(
            IPermisoRolRepository repository,
            IMapper<ListarPermisoRolPaginadoRequest, ListarPermisoRolPaginadoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, PagedResult<PermisoRolResult>>> ExecuteAsync(ListarPermisoRolPaginadoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListByPaginationAsync(parameters);
            return result;
        }
    }
}
