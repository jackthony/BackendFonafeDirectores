using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Rubro.Dtos;
using Empresa.Domain.Rubro.Parameters;
using Empresa.Domain.Rubro.Repositories;

namespace Empresa.Application.Rubro.UseCases
{
    public class CrearRubroUseCase : IUseCase<CrearRubroRequest, SpResultBase>
    {
        private readonly IRubroRepository _repository;
        private readonly IMapper<CrearRubroRequest, CrearRubroParameters> _mapper;

        public CrearRubroUseCase(IRubroRepository repository, IMapper<CrearRubroRequest, CrearRubroParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearRubroRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
