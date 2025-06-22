using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Empresa.Dtos;
using Empresa.Domain.Empresa.Parameters;
using Empresa.Domain.Empresa.Repositories;
using Empresa.Domain.Empresa.Results;

namespace Empresa.Application.Empresa.UseCases
{
    public class ListarEmpresaUseCase : IUseCase<ListarEmpresaRequest, List<EmpresaResult>>
    {
        private readonly IEmpresaRepository _repository;
        private readonly IMapper<ListarEmpresaRequest, ListarEmpresaParameters> _mapper;

        public ListarEmpresaUseCase(
            IEmpresaRepository repository,
            IMapper<ListarEmpresaRequest, ListarEmpresaParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<EmpresaResult>>> ExecuteAsync(ListarEmpresaRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListAsync(parameters);
            return result;
        }
    }
}
