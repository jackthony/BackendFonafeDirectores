/***********
* Nombre del archivo: CrearPermisoRolUseCase.cs
* Descripción:        **Caso de uso** para la creación de un nuevo permiso de rol.
*                     Orquesta el proceso de añadir un nuevo permiso de rol, transformando la solicitud
*                     a parámetros de dominio y utilizando el **repositorio** para ejecutar la operación
*                     de adición, manejando el resultado de la misma.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para crear un permiso de rol.
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
    public class CrearPermisoRolUseCase : IUseCase<CrearPermisoRolRequest, SpResultBase>
    {
        private readonly IPermisoRolRepository _repository;
        private readonly IMapper<CrearPermisoRolRequest, CrearPermisoRolParameters> _mapper;

        public CrearPermisoRolUseCase(IPermisoRolRepository repository, IMapper<CrearPermisoRolRequest, CrearPermisoRolParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearPermisoRolRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
