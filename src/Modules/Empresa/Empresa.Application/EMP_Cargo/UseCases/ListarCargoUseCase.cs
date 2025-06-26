using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Cargo.Dtos;
using Empresa.Domain.Cargo.Parameters;
using Empresa.Domain.Cargo.Repositories;
using Empresa.Domain.Cargo.Results;

namespace Empresa.Application.Cargo.UseCases
{
    public class ListarCargoUseCase : IUseCase<ListarCargoRequest, List<CargoResult>>
    {
        private readonly ICargoRepository _repository;
        private readonly IMapper<ListarCargoRequest, ListarCargoParameters> _mapper;

        public ListarCargoUseCase(
            ICargoRepository repository,
            IMapper<ListarCargoRequest, ListarCargoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<CargoResult>>> ExecuteAsync(ListarCargoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListAsync(parameters);
            return result;
        }
    }
}
