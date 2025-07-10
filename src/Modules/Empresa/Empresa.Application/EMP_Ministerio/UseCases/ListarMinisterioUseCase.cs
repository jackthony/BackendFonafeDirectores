/*****
 * Nombre de clase:     ListarMinisterioUseCase
 * Descripción:         Caso de uso encargado de listar ministerios según los parámetros definidos
 *                      en el DTO ListarMinisterioRequest. Utiliza un mapper para transformar el DTO
 *                      en parámetros de búsqueda y consulta el repositorio correspondiente.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para implementar la lógica de listado simple de ministerios.
 *****/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Ministerio.Dtos;
using Empresa.Domain.Ministerio.Parameters;
using Empresa.Domain.Ministerio.Repositories;
using Empresa.Domain.Ministerio.Results;

namespace Empresa.Application.Ministerio.UseCases
{
    public class ListarMinisterioUseCase : IUseCase<ListarMinisterioRequest, List<MinisterioResult>>
    {
        private readonly IMinisterioRepository _repository;
        private readonly IMapper<ListarMinisterioRequest, ListarMinisterioParameters> _mapper;

        public ListarMinisterioUseCase(
            IMinisterioRepository repository,
            IMapper<ListarMinisterioRequest, ListarMinisterioParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<MinisterioResult>>> ExecuteAsync(ListarMinisterioRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListAsync(parameters);
            return result;
        }
    }
}
