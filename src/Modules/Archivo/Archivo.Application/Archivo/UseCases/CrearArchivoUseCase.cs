using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Archivo.Application.Archivo.Dtos;
using Archivo.Domain.Archivo.Parameters;
using Archivo.Domain.Archivo.Repositories;
using Archivo.Application.Archivo.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Archivo.Application.Archivo.UseCases
{
    public class CrearArchivoUseCase : IUseCase<CrearArchivoRequest, SpResultBase>
    {
        private readonly IArchivoRepository _repository;
        private readonly IMapper<CrearArchivoRequest, CrearArchivoParameters> _mapper;
        private readonly IStorageService _storageService;

        public CrearArchivoUseCase(IArchivoRepository repository, IMapper<CrearArchivoRequest, CrearArchivoParameters> mapper, IStorageService storageService)
        {
            _repository = repository;
            _mapper = mapper;
            _storageService = storageService;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(CrearArchivoRequest request)
        {
            var parameters = _mapper.Map(request);
            if (request.IsDocumento && request.Archivo != null)
            {
                var url = await _storageService.SubirPrueba(request.Archivo);
                parameters.UrlStorage = url ?? "";
                /*var ruta = $"archivos/{Guid.NewGuid()}_{request.Nombre}";
                var url = await _storageService.SubirArchivoAsync(request.Archivo.OpenReadStream(), ruta, request.Archivo.ContentType);
                parameters.UrlStorage = url;*/
            }            
            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
