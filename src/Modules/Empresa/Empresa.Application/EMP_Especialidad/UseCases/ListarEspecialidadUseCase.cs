/*****
 * Nombre de clase:     ListarEspecialidadUseCase
 * Descripción:         Caso de uso para listar especialidades según los parámetros proporcionados.
 *                      Mapea la solicitud al parámetro del dominio y obtiene la lista desde el repositorio.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase implementada para la obtención de listas de especialidades.
 *****/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Especialidad.Dtos;
using Empresa.Domain.Especialidad.Parameters;
using Empresa.Domain.Especialidad.Repositories;
using Empresa.Domain.Especialidad.Results;

namespace Empresa.Application.Especialidad.UseCases
{
    public class ListarEspecialidadUseCase : IUseCase<ListarEspecialidadRequest, List<EspecialidadResult>>
    {
        private readonly IEspecialidadRepository _repository;
        private readonly IMapper<ListarEspecialidadRequest, ListarEspecialidadParameters> _mapper;

        public ListarEspecialidadUseCase(
            IEspecialidadRepository repository,
            IMapper<ListarEspecialidadRequest, ListarEspecialidadParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<EspecialidadResult>>> ExecuteAsync(ListarEspecialidadRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListAsync(parameters);
            return result;
        }
    }
}
