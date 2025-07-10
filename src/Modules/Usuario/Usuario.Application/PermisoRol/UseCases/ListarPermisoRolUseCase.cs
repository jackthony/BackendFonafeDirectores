/***********
* Nombre del archivo: ListarPermisoRolUseCase.cs
* Descripción:        **Caso de uso** para listar todos los permisos de rol.
*                     Orquesta la lógica para obtener una colección de permisos de rol,
*                     transformando la solicitud a parámetros de dominio y utilizando el **repositorio**
*                     para acceder a los datos.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para listar permisos de rol.
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
    public class ListarPermisoRolUseCase : IUseCase<ListarPermisoRolRequest, List<PermisoRolResult>>
    {
        private readonly IPermisoRolRepository _repository;
        private readonly IMapper<ListarPermisoRolRequest, ListarPermisoRolParameters> _mapper;

        public ListarPermisoRolUseCase(
            IPermisoRolRepository repository,
            IMapper<ListarPermisoRolRequest, ListarPermisoRolParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<PermisoRolResult>>> ExecuteAsync(ListarPermisoRolRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListAsync(parameters);
            return result;
        }
    }
}
