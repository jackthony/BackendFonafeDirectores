using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Empresa.Application.Dieta.Dtos;
using Empresa.Domain.Dieta.Parameters;
using Empresa.Domain.Dieta.Repositories;
using Empresa.Domain.Dieta.Results;

namespace Empresa.Application.Dieta.UseCases
{
    public class ObtenerDietaUseCase : IUseCase<ObtenerDietaRequest, DietaResult?>
    {
        private readonly IDietaRepository _repository;
        private readonly IMapper<ObtenerDietaRequest, ObtenerDietaParameter> _mapper;

        public ObtenerDietaUseCase(
            IDietaRepository repository,
            IMapper<ObtenerDietaRequest, ObtenerDietaParameter> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, DietaResult?>> ExecuteAsync(ObtenerDietaRequest request)
        {
            var parameter = _mapper.Map(request);
            var result = await _repository.ObtenerDietaAsync(parameter);

            if (result == null)
                return ErrorBase.NotFound();

            return result;
        }
    }
}
