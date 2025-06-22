using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Cargo.Dtos;
using Empresa.Domain.Cargo.Parameters;
using Empresa.Domain.Cargo.Repositories;

namespace Empresa.Application.Cargo.UseCases
{
    public class CrearCargoUseCase : IUseCase<CrearCargoRequest, SpResultBase>
    {
        private readonly ICargoRepository _repository;
        private readonly IMapper<CrearCargoRequest, CrearCargoParameters> _mapper;

        public CrearCargoUseCase(ICargoRepository repository, IMapper<CrearCargoRequest, CrearCargoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearCargoRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
