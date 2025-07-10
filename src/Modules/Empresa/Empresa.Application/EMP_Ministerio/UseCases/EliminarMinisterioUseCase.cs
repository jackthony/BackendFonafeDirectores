/*****
 * Nombre de clase:     EliminarMinisterioUseCase
 * Descripción:         Caso de uso encargado de procesar la eliminación de un ministerio.
 *                      Utiliza un mapper para transformar el DTO EliminarMinisterioRequest en
 *                      parámetros de dominio y luego ejecuta la operación en el repositorio.
 *                      Devuelve un resultado base o un error si ocurre algún fallo en la base de datos.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para implementar la lógica de eliminación de ministerios.
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
    public class EliminarMinisterioUseCase : IUseCase<EliminarMinisterioRequest, SpResultBase>
    {
        private readonly IMinisterioRepository _repository;
        private readonly IMapper<EliminarMinisterioRequest, EliminarMinisterioParameters> _mapper;

        public EliminarMinisterioUseCase(
            IMinisterioRepository repository,
            IMapper<EliminarMinisterioRequest, EliminarMinisterioParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarMinisterioRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.DeleteAsync(parameters);

            if (!result.Success) return ErrorBase.Database(result.Message);

            return result;
        }
    }
}
