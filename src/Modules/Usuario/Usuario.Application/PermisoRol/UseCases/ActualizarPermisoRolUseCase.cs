/***********
* Nombre del archivo: ActualizarPermisoRolUseCase.cs
* Descripción:        **Caso de uso** para la actualización de un permiso de rol existente.
*                     Orquesta el proceso de actualizar la información de un permiso de rol, transformando
*                     la solicitud a parámetros de dominio y utilizando el **repositorio** para ejecutar
*                     la operación de actualización. Maneja el resultado de la operación, retornando
*                     un error de base de datos si la actualización no fue exitosa.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para actualizar un permiso de rol.
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
    public class ActualizarPermisoRolUseCase : IUseCase<ActualizarPermisoRolRequest, SpResultBase>
    {
        private readonly IPermisoRolRepository _repository;
        private readonly IMapper<ActualizarPermisoRolRequest, ActualizarPermisoRolParameters> _mapper;

        public ActualizarPermisoRolUseCase(IPermisoRolRepository repository, IMapper<ActualizarPermisoRolRequest, ActualizarPermisoRolParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarPermisoRolRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.UpdateAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
