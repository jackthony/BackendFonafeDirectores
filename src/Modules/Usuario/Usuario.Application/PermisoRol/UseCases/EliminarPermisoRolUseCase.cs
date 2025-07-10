/***********
* Nombre del archivo: EliminarPermisoRolUseCase.cs
* Descripción:        **Caso de uso** para la eliminación de un permiso de rol.
*                     Orquesta el proceso de eliminar un permiso de rol, transformando la solicitud
*                     a parámetros de dominio y utilizando el **repositorio** para ejecutar la operación
*                     de eliminación, manejando el resultado de la misma.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para eliminar un permiso de rol.
***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.PermisoRol.Dtos;
using Usuario.Domain.PermisoRol.Parameters;
using Usuario.Domain.PermisoRol.Repositories;

namespace Usuario.Application.PermisoRol.UseCases
{
    public class EliminarPermisoRolUseCase : IUseCase<EliminarPermisoRolRequest, SpResultBase>
    {
        private readonly IPermisoRolRepository _repository;
        private readonly IMapper<EliminarPermisoRolRequest, EliminarPermisoRolParameters> _mapper;

        public EliminarPermisoRolUseCase(
            IPermisoRolRepository repository,
            IMapper<EliminarPermisoRolRequest, EliminarPermisoRolParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarPermisoRolRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.DeleteAsync(parameters);

            if (!result.Success) return ErrorBase.Database(result.Message);

            return result;
        }
    }
}
