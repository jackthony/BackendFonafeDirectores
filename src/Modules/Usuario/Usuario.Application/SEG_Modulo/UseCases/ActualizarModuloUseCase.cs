using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.Modulo.Dtos;
using Usuario.Domain.Modulo.Parameters;
using Usuario.Domain.Modulo.Repositories;

namespace Usuario.Application.Modulo.UseCases
{
    public class ActualizarModuloUseCase : IUseCase<ActualizarModuloRequest, SpResultBase>
    {
        private readonly IModuloRepository _repository;
        private readonly IMapper<ActualizarModuloRequest, ActualizarModuloParameters> _mapper;

        public ActualizarModuloUseCase(IModuloRepository repository, IMapper<ActualizarModuloRequest, ActualizarModuloParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarModuloRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.UpdateAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
