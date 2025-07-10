/***********
* Nombre del archivo: CrearRolUseCase.cs
* Descripción:        Caso de uso para la creación de un nuevo rol.
*                     Orquesta el proceso de añadir un nuevo rol, transformando la solicitud
*                     a parámetros de dominio y utilizando el repositorio para ejecutar la operación
*                     de adición, manejando el resultado de la misma.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para crear un rol.
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
    public class CrearRolUseCase : IUseCase<CrearRolRequest, SpResultBase>
    {
        private readonly IRolRepository _repository;
        private readonly IMapper<CrearRolRequest, CrearRolParameters> _mapper;

        public CrearRolUseCase(IRolRepository repository, IMapper<CrearRolRequest, CrearRolParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearRolRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
