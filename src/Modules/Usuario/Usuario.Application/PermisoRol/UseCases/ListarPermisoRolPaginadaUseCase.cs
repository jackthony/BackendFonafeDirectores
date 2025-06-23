using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.PermisoRol.Dtos;
using Usuario.Domain.PermisoRol.Parameters;
using Usuario.Domain.PermisoRol.Repositories;
using Usuario.Domain.PermisoRol.Results;

namespace Usuario.Application.PermisoRol.UseCases
{
    public class ListarPermisoRolPaginadaUseCase : IUseCase<ListarPermisoRolPaginadoRequest, PagedResult<PermisoRolResult>>
    {
        private readonly IPermisoRolRepository _repository;
        private readonly IMapper<ListarPermisoRolPaginadoRequest, ListarPermisoRolPaginadoParameters> _mapper;

        public ListarPermisoRolPaginadaUseCase(
            IPermisoRolRepository repository,
            IMapper<ListarPermisoRolPaginadoRequest, ListarPermisoRolPaginadoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, PagedResult<PermisoRolResult>>> ExecuteAsync(ListarPermisoRolPaginadoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListByPaginationAsync(parameters);
            return result;
        }
    }
}
