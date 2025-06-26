using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.User.Dtos;
using Usuario.Domain.User.Parameters;
using Usuario.Domain.User.Repositories;
using Usuario.Domain.User.Results;

namespace Usuario.Application.User.UseCases
{
    public class ListarUserUseCase : IUseCase<ListarUserRequest, List<UserResult>>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper<ListarUserRequest, ListarUserParameters> _mapper;

        public ListarUserUseCase(
            IUserRepository repository,
            IMapper<ListarUserRequest, ListarUserParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<UserResult>>> ExecuteAsync(ListarUserRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListAsync(parameters);
            return result;
        }
    }
}
