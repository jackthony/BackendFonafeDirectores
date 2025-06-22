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
    public class ListarUserPaginadaUseCase : IUseCase<ListarUserPaginadoRequest, PagedResult<UserResult>>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper<ListarUserPaginadoRequest, ListarUserPaginadoParameters> _mapper;

        public ListarUserPaginadaUseCase(
            IUserRepository repository,
            IMapper<ListarUserPaginadoRequest, ListarUserPaginadoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, PagedResult<UserResult>>> ExecuteAsync(ListarUserPaginadoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListByPaginationAsync(parameters);
            return result;
        }
    }
}
