using Empresa.Application.Ubigeo.Dtos;
using Empresa.Domain.Ubigeo.Parameters;
using Empresa.Domain.Ubigeo.Repositories;
using Empresa.Domain.Ubigeo.Results;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.Provincia.UseCases
{
    public class ListarProvinciaUseCase : IUseCase<ListarProvinciaRequest, List<ProvinciaResult>>
    {
        private readonly IUbigeoRepository _repository;
        private readonly IMapper<ListarProvinciaRequest, ListarProvinciaParameters> _mapper;

        public ListarProvinciaUseCase(
            IUbigeoRepository repository,
            IMapper<ListarProvinciaRequest, ListarProvinciaParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<ProvinciaResult>>> ExecuteAsync(ListarProvinciaRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListProvincias(parameters);
            return result;
        }
    }
}
