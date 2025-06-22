using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Sector.Dtos;
using Empresa.Domain.Sector.Parameters;
using Empresa.Domain.Sector.Repositories;

namespace Empresa.Application.Sector.UseCases
{
    public class CrearSectorUseCase : IUseCase<CrearSectorRequest, SpResultBase>
    {
        private readonly ISectorRepository _repository;
        private readonly IMapper<CrearSectorRequest, CrearSectorParameters> _mapper;

        public CrearSectorUseCase(ISectorRepository repository, IMapper<CrearSectorRequest, CrearSectorParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearSectorRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
