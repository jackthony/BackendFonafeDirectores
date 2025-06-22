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
    public class ListarDirectorPaginadaUseCase : IUseCase<ListarDirectorPaginadoRequest, PagedResult<DirectorResult>>
    {
        private readonly IDirectorRepository _repository;
        private readonly IMapper<ListarDirectorPaginadoRequest, ListarDirectorPaginadoParameters> _mapper;

        public ListarDirectorPaginadaUseCase(
            IDirectorRepository repository,
            IMapper<ListarDirectorPaginadoRequest, ListarDirectorPaginadoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, PagedResult<DirectorResult>>> ExecuteAsync(ListarDirectorPaginadoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListByPaginationAsync(parameters);
            return result;
        }
    }
}
