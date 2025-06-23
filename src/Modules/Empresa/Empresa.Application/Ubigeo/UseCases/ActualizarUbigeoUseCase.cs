using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Ubigeo.Dtos;
using Empresa.Domain.Ubigeo.Parameters;
using Empresa.Domain.Ubigeo.Repositories;

namespace Empresa.Application.Ubigeo.UseCases
{
    public class ActualizarUbigeoUseCase : IUseCase<ActualizarUbigeoRequest, SpResultBase>
    {
        private readonly IUbigeoRepository _repository;
        private readonly IMapper<ActualizarUbigeoRequest, ActualizarUbigeoParameters> _mapper;

        public ActualizarUbigeoUseCase(IUbigeoRepository repository, IMapper<ActualizarUbigeoRequest, ActualizarUbigeoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarUbigeoRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.UpdateAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
