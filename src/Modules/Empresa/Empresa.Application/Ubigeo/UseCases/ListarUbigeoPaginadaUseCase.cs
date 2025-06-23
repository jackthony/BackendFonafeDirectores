using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Ubigeo.Dtos;
using Empresa.Domain.Ubigeo.Parameters;
using Empresa.Domain.Ubigeo.Repositories;
using Empresa.Domain.Ubigeo.Results;

namespace Empresa.Application.Ubigeo.UseCases
{
    public class ListarUbigeoPaginadaUseCase : IUseCase<ListarUbigeoPaginadoRequest, PagedResult<UbigeoResult>>
    {
        private readonly IUbigeoRepository _repository;
        private readonly IMapper<ListarUbigeoPaginadoRequest, ListarUbigeoPaginadoParameters> _mapper;

        public ListarUbigeoPaginadaUseCase(
            IUbigeoRepository repository,
            IMapper<ListarUbigeoPaginadoRequest, ListarUbigeoPaginadoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, PagedResult<UbigeoResult>>> ExecuteAsync(ListarUbigeoPaginadoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListByPaginationAsync(parameters);
            return result;
        }
    }
}
