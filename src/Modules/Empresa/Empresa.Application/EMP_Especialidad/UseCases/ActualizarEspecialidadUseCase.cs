using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Especialidad.Dtos;
using Empresa.Domain.Especialidad.Parameters;
using Empresa.Domain.Especialidad.Repositories;

namespace Empresa.Application.Especialidad.UseCases
{
    public class ActualizarEspecialidadUseCase : IUseCase<ActualizarEspecialidadRequest, SpResultBase>
    {
        private readonly IEspecialidadRepository _repository;
        private readonly IMapper<ActualizarEspecialidadRequest, ActualizarEspecialidadParameters> _mapper;

        public ActualizarEspecialidadUseCase(IEspecialidadRepository repository, IMapper<ActualizarEspecialidadRequest, ActualizarEspecialidadParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarEspecialidadRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.UpdateAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
