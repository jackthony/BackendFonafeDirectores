using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.Auth.Services;
using Usuario.Application.Rol.Dtos;
using Usuario.Domain.Rol.Parameters;
using Usuario.Domain.Rol.Repositories;

namespace Usuario.Application.Rol.UseCases
{
    public class CrearRolUseCase : IUseCase<CrearRolRequest, SpResultBase>
    {
        private readonly IRolRepository _repository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IMapper<CrearRolRequest, CrearRolParameters> _mapper;

        public CrearRolUseCase(IRolRepository repository, IPasswordHasher passwordHasher, IMapper<CrearRolRequest, CrearRolParameters> mapper)
        {
            _repository = repository;
            _passwordHasher = passwordHasher;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearRolRequest request)
        {
            request.Password = _passwordHasher.Hash(request.Password);
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
