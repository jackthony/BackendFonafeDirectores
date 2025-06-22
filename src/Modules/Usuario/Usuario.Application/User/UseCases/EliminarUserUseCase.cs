using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.User.Dtos;
using Usuario.Domain.User.Parameters;
using Usuario.Domain.User.Repositories;

namespace Usuario.Application.User.UseCases
{
    public class EliminarUserUseCase : IUseCase<EliminarUserRequest, SpResultBase>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper<EliminarUserRequest, EliminarUserParameters> _mapper;

        public EliminarUserUseCase(
            IUserRepository repository,
            IMapper<EliminarUserRequest, EliminarUserParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarUserRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.DeleteAsync(parameters);

            if (!result.Success) return ErrorBase.Database(result.Message);

            return result;
        }
    }
}
