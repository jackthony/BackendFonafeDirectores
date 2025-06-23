using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Ubigeo.Dtos;
using Empresa.Domain.Ubigeo.Parameters;
using Empresa.Domain.Ubigeo.Repositories;
using Empresa.Domain.Ubigeo.Results;

namespace Empresa.Application.Ubigeo.UseCases
{
    public class ListarUbigeoUseCase : IUseCase<ListarUbigeoRequest, List<UbigeoResult>>
    {
        private readonly IUbigeoRepository _repository;
        private readonly IMapper<ListarUbigeoRequest, ListarUbigeoParameters> _mapper;

        public ListarUbigeoUseCase(
            IUbigeoRepository repository,
            IMapper<ListarUbigeoRequest, ListarUbigeoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<UbigeoResult>>> ExecuteAsync(ListarUbigeoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListAsync(parameters);
            return result;
        }
    }
}
