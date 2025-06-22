using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Rubro.Dtos;
using Empresa.Domain.Rubro.Parameters;
using Empresa.Domain.Rubro.Repositories;

namespace Empresa.Application.Rubro.UseCases
{
    public class EliminarRubroUseCase : IUseCase<EliminarRubroRequest, SpResultBase>
    {
        private readonly IRubroRepository _repository;
        private readonly IMapper<EliminarRubroRequest, EliminarRubroParameters> _mapper;

        public EliminarRubroUseCase(
            IRubroRepository repository,
            IMapper<EliminarRubroRequest, EliminarRubroParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarRubroRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.DeleteAsync(parameters);

            if (!result.Success) return ErrorBase.Database(result.Message);

            return result;
        }
    }
}
