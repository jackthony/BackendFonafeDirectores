using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.Rol.Dtos;
using Usuario.Domain.Rol.Parameters;
using Usuario.Domain.Rol.Repositories;

namespace Usuario.Application.Rol.UseCases
{
    public class ActualizarRolUseCase : IUseCase<ActualizarRolRequest, SpResultBase>
    {
        private readonly IRolRepository _repository;
        private readonly IMapper<ActualizarRolRequest, ActualizarRolParameters> _mapper;

        public ActualizarRolUseCase(IRolRepository repository, IMapper<ActualizarRolRequest, ActualizarRolParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarRolRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.UpdateAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
