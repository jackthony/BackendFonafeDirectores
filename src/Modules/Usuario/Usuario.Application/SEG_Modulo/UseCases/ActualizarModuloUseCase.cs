/***********
* Nombre del archivo: ActualizarModuloUseCase.cs
* Descripción:        **Caso de uso** para la actualización de un módulo existente.
*                     Orquesta el proceso de actualizar la información de un módulo, transformando
*                     la solicitud a parámetros de dominio y utilizando el **repositorio** para ejecutar
*                     la operación de actualización.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para actualizar un módulo.
***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.Modulo.Dtos;
using Usuario.Domain.Modulo.Parameters;
using Usuario.Domain.Modulo.Repositories;

namespace Usuario.Application.Modulo.UseCases
{
    public class ActualizarModuloUseCase : IUseCase<ActualizarModuloRequest, SpResultBase>
    {
        private readonly IModuloRepository _repository;
        private readonly IMapper<ActualizarModuloRequest, ActualizarModuloParameters> _mapper;

        public ActualizarModuloUseCase(IModuloRepository repository, IMapper<ActualizarModuloRequest, ActualizarModuloParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarModuloRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.UpdateAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
