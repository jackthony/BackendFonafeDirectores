using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Cargo.Dtos;
using Empresa.Domain.Cargo.Parameters;
using Empresa.Domain.Cargo.Repositories;

namespace Empresa.Application.Cargo.UseCases
{
    public class EliminarCargoUseCase : IUseCase<EliminarCargoRequest, SpResultBase>
    {
        private readonly ICargoRepository _repository;
        private readonly IMapper<EliminarCargoRequest, EliminarCargoParameters> _mapper;

        public EliminarCargoUseCase(
            ICargoRepository repository,
            IMapper<EliminarCargoRequest, EliminarCargoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarCargoRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.DeleteAsync(parameters);

            if (!result.Success) return ErrorBase.Database(result.Message);

            return result;
        }
    }
}
