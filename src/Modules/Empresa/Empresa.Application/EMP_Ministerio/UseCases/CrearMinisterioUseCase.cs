using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Ministerio.Dtos;
using Empresa.Domain.Ministerio.Parameters;
using Empresa.Domain.Ministerio.Repositories;

namespace Empresa.Application.Ministerio.UseCases
{
    public class CrearMinisterioUseCase : IUseCase<CrearMinisterioRequest, SpResultBase>
    {
        private readonly IMinisterioRepository _repository;
        private readonly IMapper<CrearMinisterioRequest, CrearMinisterioParameters> _mapper;

        public CrearMinisterioUseCase(IMinisterioRepository repository, IMapper<CrearMinisterioRequest, CrearMinisterioParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearMinisterioRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
