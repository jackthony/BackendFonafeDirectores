using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Sector.Dtos;
using Empresa.Domain.Sector.Parameters;
using Empresa.Domain.Sector.Repositories;

namespace Empresa.Application.Sector.UseCases
{
    public class ActualizarSectorUseCase : IUseCase<ActualizarSectorRequest, SpResultBase>
    {
        private readonly ISectorRepository _repository;
        private readonly IMapper<ActualizarSectorRequest, ActualizarSectorParameters> _mapper;

        public ActualizarSectorUseCase(ISectorRepository repository, IMapper<ActualizarSectorRequest, ActualizarSectorParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarSectorRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.UpdateAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
