using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Empresa.Dtos;
using Empresa.Domain.Empresa.Parameters;
using Empresa.Domain.Empresa.Repositories;

namespace Empresa.Application.Empresa.UseCases
{
    public class CrearEmpresaUseCase : IUseCase<CrearEmpresaRequest, SpResultBase>
    {
        private readonly IEmpresaRepository _repository;
        private readonly IMapper<CrearEmpresaRequest, CrearEmpresaParameters> _mapper;

        public CrearEmpresaUseCase(IEmpresaRepository repository, IMapper<CrearEmpresaRequest, CrearEmpresaParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearEmpresaRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
