using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Usuario.Application.Dtos;
using Usuario.Application.Repositories;
using Usuario.Domain.User.Repositories;
using Usuario.Domain.User.Results;

namespace Usuario.Application.User.UseCases
{
    public class ObtenerUserPorIdUseCase : IUseCase<int, UserResult?>
    {
        private readonly IUserRepository _repository;

        public ObtenerUserPorIdUseCase(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, UserResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
