using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.Modulo.Dtos;
using Usuario.Domain.Modulo.Parameters;
using Usuario.Domain.Modulo.Repositories;

namespace Usuario.Application.Modulo.UseCases
{
    public class CrearModuloUseCase : IUseCase<CrearModuloRequest, SpResultBase>
    {
        private readonly IModuloRepository _repository;
        private readonly IMapper<CrearModuloRequest, CrearModuloParameters> _mapper;

        public CrearModuloUseCase(IModuloRepository repository, IMapper<CrearModuloRequest, CrearModuloParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearModuloRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
