using Empresa.Application.Ubigeo.Dtos;
using Empresa.Domain.Ubigeo.Parameters;
using Empresa.Domain.Ubigeo.Repositories;
using Empresa.Domain.Ubigeo.Results;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.Departamento.UseCases
{
    public class ListarDepartamentoUseCase : IUseCase<ListarDepartamentoRequest, List<DepartamentoResult>>
    {
        private readonly IUbigeoRepository _repository;
        private readonly IMapper<ListarDepartamentoRequest, ListarDepartamentoParameters> _mapper;

        public ListarDepartamentoUseCase(
            IUbigeoRepository repository,
            IMapper<ListarDepartamentoRequest, ListarDepartamentoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<DepartamentoResult>>> ExecuteAsync(ListarDepartamentoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListDepartamentos(parameters);
            return result;
        }
    }
}
