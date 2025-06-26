using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Rubro.Dtos;
using Empresa.Domain.Rubro.Parameters;
using Empresa.Domain.Rubro.Repositories;
using Empresa.Domain.Rubro.Results;

namespace Empresa.Application.Rubro.UseCases
{
    public class ListarRubroPaginadaUseCase : IUseCase<ListarRubroPaginadoRequest, PagedResult<RubroResult>>
    {
        private readonly IRubroRepository _repository;
        private readonly IMapper<ListarRubroPaginadoRequest, ListarRubroPaginadoParameters> _mapper;

        public ListarRubroPaginadaUseCase(
            IRubroRepository repository,
            IMapper<ListarRubroPaginadoRequest, ListarRubroPaginadoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, PagedResult<RubroResult>>> ExecuteAsync(ListarRubroPaginadoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListByPaginationAsync(parameters);
            return result;
        }
    }
}
