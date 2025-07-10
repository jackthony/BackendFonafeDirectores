/***********
* Nombre del archivo: CrearPermisosRolUseCase.cs
* Descripción:        Caso de uso para la creación de permisos asociados a un rol.
*                     Orquesta el proceso de asignar o actualizar los permisos de un rol,
*                     transformando la solicitud a parámetros de dominio y utilizando el repositorio
*                     para persistir los cambios, manejando el resultado de la operación.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para crear permisos de rol.
***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.SEG_Rol.Dtos;
using Usuario.Domain.Rol.Repositories;
using Usuario.Domain.SEG_Rol.Parameters;

namespace Usuario.Application.SEG_Rol.UseCases
{
    public class CrearPermisosRolUseCase : IUseCase<CrearPermisosRolRequest, SpResultBase>
    {
        private readonly IRolRepository _repository;
        private readonly IMapper<CrearPermisosRolRequest, CrearPermisosRolParameters> _mapper;

        public CrearPermisosRolUseCase(
            IRolRepository repository,
            IMapper<CrearPermisosRolRequest, CrearPermisosRolParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearPermisosRolRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.AddPermisosRolesAsync(parameters);

            if (!result.Success)
                return ErrorBase.Database(result.Message);

            return result;
        }
    }
}
