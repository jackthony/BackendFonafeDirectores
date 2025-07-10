/*****
 * Nombre del archivo:  ListarTipoDirectorUseCase.cs
 * Descripción:         Caso de uso para listar tipos de director. Convierte la solicitud en parámetros
 *                      de dominio y consulta el repositorio para obtener la lista de resultados.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Application.TipoDirector.Dtos;
using Empresa.Domain.TipoDirector.Parameters;
using Empresa.Domain.TipoDirector.Repositories;
using Empresa.Domain.TipoDirector.Results;

namespace Empresa.Application.TipoDirector.UseCases
{
    public class ListarTipoDirectorUseCase : IUseCase<ListarTipoDirectorRequest, List<TipoDirectorResult>>
    {
        private readonly ITipoDirectorRepository _repository;
        private readonly IMapper<ListarTipoDirectorRequest, ListarTipoDirectorParameters> _mapper;

        public ListarTipoDirectorUseCase(
            ITipoDirectorRepository repository,
            IMapper<ListarTipoDirectorRequest, ListarTipoDirectorParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<TipoDirectorResult>>> ExecuteAsync(ListarTipoDirectorRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListAsync(parameters);
            return result;
        }
    }
}
