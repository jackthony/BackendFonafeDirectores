using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.TipoDirector.Dtos;
using Empresa.Domain.TipoDirector.Parameters;
using Empresa.Domain.TipoDirector.Repositories;
using Empresa.Domain.TipoDirector.Results;

namespace Empresa.Application.TipoDirector.UseCases
{
    public class ListarTipoDirectorUseCase : IUseCase<ListarTipoDirectorRequest, List<TipoDirectorResult>>
    {
        private readonly ITipoDirectorRepository _repository;
        private readonly IMapper<ListarTipoDirectorRequest, ListarTipoDirectorParameters> _mapper;

        public ListarTipoDirectorUseCase(
            ITipoDirectorRepository repository,
            IMapper<ListarTipoDirectorRequest, ListarTipoDirectorParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<TipoDirectorResult>>> ExecuteAsync(ListarTipoDirectorRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListAsync(parameters);
            return result;
        }
    }
}
