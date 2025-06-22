using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Ministerio.Dtos;
using Empresa.Domain.Ministerio.Parameters;
using Empresa.Domain.Ministerio.Repositories;
using Empresa.Domain.Ministerio.Results;

namespace Empresa.Application.Ministerio.UseCases
{
    public class ListarMinisterioUseCase : IUseCase<ListarMinisterioRequest, List<MinisterioResult>>
    {
        private readonly IMinisterioRepository _repository;
        private readonly IMapper<ListarMinisterioRequest, ListarMinisterioParameters> _mapper;

        public ListarMinisterioUseCase(
            IMinisterioRepository repository,
            IMapper<ListarMinisterioRequest, ListarMinisterioParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<MinisterioResult>>> ExecuteAsync(ListarMinisterioRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListAsync(parameters);
            return result;
        }
    }
}
