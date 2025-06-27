using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.Rol.Dtos;
using Usuario.Domain.Rol.Parameters;
using Usuario.Domain.Rol.Repositories;
using Usuario.Domain.Rol.Results;

namespace Usuario.Application.Rol.UseCases
{
    public class ListarRolPaginadaUseCase : IUseCase<ListarRolPaginadoRequest, PagedResult<RolResult>>
    {
        private readonly IRolRepository _repository;
        private readonly IMapper<ListarRolPaginadoRequest, ListarRolPaginadoParameters> _mapper;

        public ListarRolPaginadaUseCase(
            IRolRepository repository,
            IMapper<ListarRolPaginadoRequest, ListarRolPaginadoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, PagedResult<RolResult>>> ExecuteAsync(ListarRolPaginadoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListByPaginationAsync(parameters);
            return result;
        }
    }
}
