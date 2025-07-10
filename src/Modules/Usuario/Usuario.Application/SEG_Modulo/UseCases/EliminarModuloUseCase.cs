/***********
* Nombre del archivo: EliminarModuloUseCase.cs
* Descripción:        **Caso de uso** para la eliminación de un módulo.
*                     Orquesta el proceso de eliminar un módulo, transformando la solicitud
*                     a parámetros de dominio y utilizando el **repositorio** para ejecutar la operación
*                     de eliminación, manejando el resultado de la misma.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para eliminar un módulo.
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
    public class EliminarModuloUseCase : IUseCase<EliminarModuloRequest, SpResultBase>
    {
        private readonly IModuloRepository _repository;
        private readonly IMapper<EliminarModuloRequest, EliminarModuloParameters> _mapper;

        public EliminarModuloUseCase(
            IModuloRepository repository,
            IMapper<EliminarModuloRequest, EliminarModuloParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarModuloRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.DeleteAsync(parameters);

            if (!result.Success) return ErrorBase.Database(result.Message);

            return result;
        }
    }
}
