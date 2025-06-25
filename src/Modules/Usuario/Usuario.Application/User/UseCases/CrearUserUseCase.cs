using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.Auth.Services;
using Usuario.Application.User.Dtos;
using Usuario.Domain.User.Parameters;
using Usuario.Domain.User.Repositories;

namespace Usuario.Application.User.UseCases
{
    public class CrearUserUseCase : IUseCase<CrearUserRequest, SpResultBase>
    {
        private readonly IUserRepository _repository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IMapper<CrearUserRequest, CrearUserParameters> _mapper;

        public CrearUserUseCase(IUserRepository repository, IPasswordHasher passwordHasher, IMapper<CrearUserRequest, CrearUserParameters> mapper)
        {
            _repository = repository;
            _passwordHasher = passwordHasher;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearUserRequest request)
        {
            request.sContrasena = _passwordHasher.Hash(request.sContrasena);
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
