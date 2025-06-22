using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.Modulo.Dtos;
using Usuario.Domain.Modulo.Parameters;
using Usuario.Domain.Modulo.Repositories;
using Usuario.Domain.Modulo.Results;

namespace Usuario.Application.Modulo.UseCases
{
    public class ListarModuloPaginadaUseCase : IUseCase<ListarModuloPaginadoRequest, PagedResult<ModuloResult>>
    {
        private readonly IModuloRepository _repository;
        private readonly IMapper<ListarModuloPaginadoRequest, ListarModuloPaginadoParameters> _mapper;

        public ListarModuloPaginadaUseCase(
            IModuloRepository repository,
            IMapper<ListarModuloPaginadoRequest, ListarModuloPaginadoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, PagedResult<ModuloResult>>> ExecuteAsync(ListarModuloPaginadoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListByPaginationAsync(parameters);
            return result;
        }
    }
}
