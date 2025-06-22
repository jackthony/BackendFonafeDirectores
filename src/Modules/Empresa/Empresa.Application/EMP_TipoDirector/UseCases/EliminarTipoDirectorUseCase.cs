using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.TipoDirector.Dtos;
using Empresa.Domain.TipoDirector.Parameters;
using Empresa.Domain.TipoDirector.Repositories;

namespace Empresa.Application.TipoDirector.UseCases
{
    public class EliminarTipoDirectorUseCase : IUseCase<EliminarTipoDirectorRequest, SpResultBase>
    {
        private readonly ITipoDirectorRepository _repository;
        private readonly IMapper<EliminarTipoDirectorRequest, EliminarTipoDirectorParameters> _mapper;

        public EliminarTipoDirectorUseCase(
            ITipoDirectorRepository repository,
            IMapper<EliminarTipoDirectorRequest, EliminarTipoDirectorParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarTipoDirectorRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.DeleteAsync(parameters);

            if (!result.Success) return ErrorBase.Database(result.Message);

            return result;
        }
    }
}
