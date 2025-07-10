/***********
* Nombre del archivo: EliminarRolUseCase.cs
* Descripción:        Caso de uso para la eliminación de un rol.
*                     Orquesta el proceso de eliminar un rol, transformando la solicitud
*                     a parámetros de dominio y utilizando el repositorio para ejecutar la operación
*                     de eliminación, manejando el resultado de la misma.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para eliminar un rol.
***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.Rol.Dtos;
using Usuario.Domain.Rol.Parameters;
using Usuario.Domain.Rol.Repositories;

namespace Usuario.Application.Rol.UseCases
{
    public class EliminarRolUseCase : IUseCase<EliminarRolRequest, SpResultBase>
    {
        private readonly IRolRepository _repository;
        private readonly IMapper<EliminarRolRequest, EliminarRolParameters> _mapper;

        public EliminarRolUseCase(
            IRolRepository repository,
            IMapper<EliminarRolRequest, EliminarRolParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarRolRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.DeleteAsync(parameters);

            if (!result.Success) return ErrorBase.Database(result.Message);

            return result;
        }
    }
}
