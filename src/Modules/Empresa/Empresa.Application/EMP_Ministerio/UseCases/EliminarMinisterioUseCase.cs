using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Ministerio.Dtos;
using Empresa.Domain.Ministerio.Parameters;
using Empresa.Domain.Ministerio.Repositories;

namespace Empresa.Application.Ministerio.UseCases
{
    public class EliminarMinisterioUseCase : IUseCase<EliminarMinisterioRequest, SpResultBase>
    {
        private readonly IMinisterioRepository _repository;
        private readonly IMapper<EliminarMinisterioRequest, EliminarMinisterioParameters> _mapper;

        public EliminarMinisterioUseCase(
            IMinisterioRepository repository,
            IMapper<EliminarMinisterioRequest, EliminarMinisterioParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarMinisterioRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.DeleteAsync(parameters);

            if (!result.Success) return ErrorBase.Database(result.Message);

            return result;
        }
    }
}
