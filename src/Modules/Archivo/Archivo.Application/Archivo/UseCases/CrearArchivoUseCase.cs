using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Archivo.Application.Archivo.Dtos;
using Archivo.Domain.Archivo.Parameters;
using Archivo.Domain.Archivo.Repositories;

namespace Archivo.Application.Archivo.UseCases
{
    public class CrearArchivoUseCase : IUseCase<CrearArchivoRequest, SpResultBase>
    {
        private readonly IArchivoRepository _repository;
        private readonly IMapper<CrearArchivoRequest, CrearArchivoParameters> _mapper;

        public CrearArchivoUseCase(IArchivoRepository repository, IMapper<CrearArchivoRequest, CrearArchivoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearArchivoRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
