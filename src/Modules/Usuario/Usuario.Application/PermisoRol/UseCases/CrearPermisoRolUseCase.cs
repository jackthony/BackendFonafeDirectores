using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.Auth.Services;
using Usuario.Application.PermisoRol.Dtos;
using Usuario.Domain.PermisoRol.Parameters;
using Usuario.Domain.PermisoRol.Repositories;

namespace Usuario.Application.PermisoRol.UseCases
{
    public class CrearPermisoRolUseCase : IUseCase<CrearPermisoRolRequest, SpResultBase>
    {
        private readonly IPermisoRolRepository _repository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IMapper<CrearPermisoRolRequest, CrearPermisoRolParameters> _mapper;

        public CrearPermisoRolUseCase(IPermisoRolRepository repository, IPasswordHasher passwordHasher, IMapper<CrearPermisoRolRequest, CrearPermisoRolParameters> mapper)
        {
            _repository = repository;
            _passwordHasher = passwordHasher;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearPermisoRolRequest request)
        {
            request.Password = _passwordHasher.Hash(request.Password);
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
