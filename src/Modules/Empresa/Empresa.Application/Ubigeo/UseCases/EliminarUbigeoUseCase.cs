using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Ubigeo.Dtos;
using Empresa.Domain.Ubigeo.Parameters;
using Empresa.Domain.Ubigeo.Repositories;

namespace Empresa.Application.Ubigeo.UseCases
{
    public class EliminarUbigeoUseCase : IUseCase<EliminarUbigeoRequest, SpResultBase>
    {
        private readonly IUbigeoRepository _repository;
        private readonly IMapper<EliminarUbigeoRequest, EliminarUbigeoParameters> _mapper;

        public EliminarUbigeoUseCase(
            IUbigeoRepository repository,
            IMapper<EliminarUbigeoRequest, EliminarUbigeoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarUbigeoRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.DeleteAsync(parameters);

            if (!result.Success) return ErrorBase.Database(result.Message);

            return result;
        }
    }
}
