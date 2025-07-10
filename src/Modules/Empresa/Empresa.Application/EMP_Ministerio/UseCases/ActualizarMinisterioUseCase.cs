/*****
 * Nombre de clase:     ActualizarMinisterioUseCase
 * Descripción:         Caso de uso encargado de actualizar los datos de un ministerio existente.
 *                      Convierte el DTO ActualizarMinisterioRequest en parámetros de dominio mediante un mapper,
 *                      y ejecuta la actualización a través del repositorio correspondiente.
 *                      Retorna un resultado base o un error en caso de fallo en la base de datos.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para implementar la lógica de actualización de ministerios.
 *****/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Ministerio.Dtos;
using Empresa.Domain.Ministerio.Parameters;
using Empresa.Domain.Ministerio.Repositories;

namespace Empresa.Application.Ministerio.UseCases
{
    public class ActualizarMinisterioUseCase : IUseCase<ActualizarMinisterioRequest, SpResultBase>
    {
        private readonly IMinisterioRepository _repository;
        private readonly IMapper<ActualizarMinisterioRequest, ActualizarMinisterioParameters> _mapper;

        public ActualizarMinisterioUseCase(IMinisterioRepository repository, IMapper<ActualizarMinisterioRequest, ActualizarMinisterioParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarMinisterioRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.UpdateAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
