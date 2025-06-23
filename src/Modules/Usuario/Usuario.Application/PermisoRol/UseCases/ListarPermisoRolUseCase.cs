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
    public class ListarPermisoRolUseCase : IUseCase<ListarPermisoRolRequest, List<PermisoRolResult>>
    {
        private readonly IPermisoRolRepository _repository;
        private readonly IMapper<ListarPermisoRolRequest, ListarPermisoRolParameters> _mapper;

        public ListarPermisoRolUseCase(
            IPermisoRolRepository repository,
            IMapper<ListarPermisoRolRequest, ListarPermisoRolParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<PermisoRolResult>>> ExecuteAsync(ListarPermisoRolRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListAsync(parameters);
            return result;
        }
    }
}
