using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.TipoDirector.Dtos;
using Empresa.Domain.TipoDirector.Parameters;
using Empresa.Domain.TipoDirector.Repositories;

namespace Empresa.Application.TipoDirector.UseCases
{
    public class CrearTipoDirectorUseCase : IUseCase<CrearTipoDirectorRequest, SpResultBase>
    {
        private readonly ITipoDirectorRepository _repository;
        private readonly IMapper<CrearTipoDirectorRequest, CrearTipoDirectorParameters> _mapper;

        public CrearTipoDirectorUseCase(ITipoDirectorRepository repository, IMapper<CrearTipoDirectorRequest, CrearTipoDirectorParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearTipoDirectorRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
