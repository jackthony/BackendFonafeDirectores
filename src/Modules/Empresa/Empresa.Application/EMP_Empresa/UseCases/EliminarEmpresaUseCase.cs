using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Empresa.Dtos;
using Empresa.Domain.Empresa.Parameters;
using Empresa.Domain.Empresa.Repositories;

namespace Empresa.Application.Empresa.UseCases
{
    public class EliminarEmpresaUseCase : IUseCase<EliminarEmpresaRequest, SpResultBase>
    {
        private readonly IEmpresaRepository _repository;
        private readonly IMapper<EliminarEmpresaRequest, EliminarEmpresaParameters> _mapper;

        public EliminarEmpresaUseCase(
            IEmpresaRepository repository,
            IMapper<EliminarEmpresaRequest, EliminarEmpresaParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarEmpresaRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.DeleteAsync(parameters);

            if (!result.Success) return ErrorBase.Database(result.Message);

            return result;
        }
    }
}
