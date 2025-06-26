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
    public class ListarRubroUseCase : IUseCase<ListarRubroRequest, List<RubroResult>>
    {
        private readonly IRubroRepository _repository;
        private readonly IMapper<ListarRubroRequest, ListarRubroParameters> _mapper;

        public ListarRubroUseCase(
            IRubroRepository repository,
            IMapper<ListarRubroRequest, ListarRubroParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<RubroResult>>> ExecuteAsync(ListarRubroRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListAsync(parameters);
            return result;
        }
    }
}
