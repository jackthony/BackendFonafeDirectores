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
    public class ListarRolUseCase : IUseCase<ListarRolRequest, List<RolResult>>
    {
        private readonly IRolRepository _repository;
        private readonly IMapper<ListarRolRequest, ListarRolParameters> _mapper;

        public ListarRolUseCase(
            IRolRepository repository,
            IMapper<ListarRolRequest, ListarRolParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<RolResult>>> ExecuteAsync(ListarRolRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListAsync(parameters);
            return result;
        }
    }
}
