using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Rubro.Dtos;
using Empresa.Domain.Rubro.Parameters;
using Empresa.Domain.Rubro.Repositories;

namespace Empresa.Application.Rubro.UseCases
{
    public class ActualizarRubroUseCase : IUseCase<ActualizarRubroRequest, SpResultBase>
    {
        private readonly IRubroRepository _repository;
        private readonly IMapper<ActualizarRubroRequest, ActualizarRubroParameters> _mapper;

        public ActualizarRubroUseCase(IRubroRepository repository, IMapper<ActualizarRubroRequest, ActualizarRubroParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarRubroRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.UpdateAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
