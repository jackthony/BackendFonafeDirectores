using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Director.Dtos;
using Empresa.Domain.Director.Parameters;
using Empresa.Domain.Director.Repositories;

namespace Empresa.Application.Director.UseCases
{
    public class CrearDirectorUseCase : IUseCase<CrearDirectorRequest, SpResultBase>
    {
        private readonly IDirectorRepository _repository;
        private readonly IMapper<CrearDirectorRequest, CrearDirectorParameters> _mapper;

        public CrearDirectorUseCase(IDirectorRepository repository, IMapper<CrearDirectorRequest, CrearDirectorParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearDirectorRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
