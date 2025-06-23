using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private readonly IDepartamentoRepository _repository;
        private readonly IMapper<ListarDepartamentoRequest, ListarDepartamentoParameters> _mapper;

        public ListarDepartamentoUseCase(
            IDepartamentoRepository repository,
            IMapper<ListarDepartamentoRequest, ListarDepartamentoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<DepartamentoResult>>> ExecuteAsync(ListarDepartamentoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListAsync(parameters);
            return result;
        }
    }
}
