using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Director.Dtos;
using Empresa.Domain.Director.Parameters;
using Empresa.Domain.Director.Repositories;

namespace Empresa.Application.Director.UseCases
{
    public class EliminarDirectorUseCase : IUseCase<EliminarDirectorRequest, SpResultBase>
    {
        private readonly IDirectorRepository _repository;
        private readonly IMapper<EliminarDirectorRequest, EliminarDirectorParameters> _mapper;

        public EliminarDirectorUseCase(
            IDirectorRepository repository,
            IMapper<EliminarDirectorRequest, EliminarDirectorParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarDirectorRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.DeleteAsync(parameters);

            if (!result.Success) return ErrorBase.Database(result.Message);

            return result;
        }
    }
}
