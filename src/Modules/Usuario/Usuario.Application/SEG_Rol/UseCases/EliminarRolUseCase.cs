using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.Rol.Dtos;
using Usuario.Domain.Rol.Parameters;
using Usuario.Domain.Rol.Repositories;

namespace Usuario.Application.Rol.UseCases
{
    public class EliminarRolUseCase : IUseCase<EliminarRolRequest, SpResultBase>
    {
        private readonly IRolRepository _repository;
        private readonly IMapper<EliminarRolRequest, EliminarRolParameters> _mapper;

        public EliminarRolUseCase(
            IRolRepository repository,
            IMapper<EliminarRolRequest, EliminarRolParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarRolRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.DeleteAsync(parameters);

            if (!result.Success) return ErrorBase.Database(result.Message);

            return result;
        }
    }
}
