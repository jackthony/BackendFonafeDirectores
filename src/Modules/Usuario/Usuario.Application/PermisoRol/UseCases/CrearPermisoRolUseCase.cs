using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.PermisoRol.Dtos;
using Usuario.Domain.PermisoRol.Parameters;
using Usuario.Domain.PermisoRol.Repositories;

namespace Usuario.Application.PermisoRol.UseCases
{
    public class CrearPermisoRolUseCase : IUseCase<CrearPermisoRolRequest, SpResultBase>
    {
        private readonly IPermisoRolRepository _repository;
        private readonly IMapper<CrearPermisoRolRequest, CrearPermisoRolParameters> _mapper;

        public CrearPermisoRolUseCase(IPermisoRolRepository repository, IMapper<CrearPermisoRolRequest, CrearPermisoRolParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearPermisoRolRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
