/*****
 * Nombre del archivo:  ListarDirectorUseCase.cs
 * Descripción:         Caso de uso para listar directores. Mapea el request (`ListarDirectorRequest`) a los parámetros correspondientes 
 *                      y obtiene la lista de directores del repositorio.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Director.Dtos;
using Empresa.Domain.Director.Parameters;
using Empresa.Domain.Director.Repositories;
using Empresa.Domain.Director.Results;

namespace Empresa.Application.Director.UseCases
{
    public class ListarDirectorUseCase : IUseCase<ListarDirectorRequest, List<DirectorResult>>
    {
        private readonly IDirectorRepository _repository;
        private readonly IMapper<ListarDirectorRequest, ListarDirectorParameters> _mapper;

        public ListarDirectorUseCase(
            IDirectorRepository repository,
            IMapper<ListarDirectorRequest, ListarDirectorParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<DirectorResult>>> ExecuteAsync(ListarDirectorRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListAsync(parameters);
            return result;
        }
    }
}
