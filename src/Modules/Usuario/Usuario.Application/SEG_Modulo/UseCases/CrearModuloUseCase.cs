/***********
* Nombre del archivo: CrearModuloUseCase.cs
* Descripción:        **Caso de uso** para la creación de un nuevo módulo.
*                     Orquesta el proceso de añadir un nuevo módulo, transformando la solicitud
*                     a parámetros de dominio y utilizando el **repositorio** para ejecutar la operación
*                     de adición, manejando el resultado de la misma.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para crear un módulo.
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
    public class CrearModuloUseCase : IUseCase<CrearModuloRequest, SpResultBase>
    {
        private readonly IModuloRepository _repository;
        private readonly IMapper<CrearModuloRequest, CrearModuloParameters> _mapper;

        public CrearModuloUseCase(IModuloRepository repository, IMapper<CrearModuloRequest, CrearModuloParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearModuloRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
