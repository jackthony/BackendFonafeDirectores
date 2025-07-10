/*****
 * Nombre del archivo:  CrearArchivoUseCase.cs
 * Descripción:         Caso de uso encargado de gestionar la creación de archivos. 
 *                      Implementa la interfaz `IUseCase`, mapeando la solicitud de creación (`CrearArchivoRequest`) a los parámetros correspondientes (`CrearArchivoParameters`),
 *                      y utilizando el servicio de almacenamiento para subir el archivo antes de registrar los detalles en el repositorio.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Archivo.Application.Archivo.Dtos;
using Archivo.Domain.Archivo.Parameters;
using Archivo.Domain.Archivo.Repositories;
using Archivo.Application.Archivo.Services;

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
                var resultado = await _storageService.SubirPrueba(request.Archivo);

                if (resultado is null)
                    return ErrorBase.Validation("Error al subir el archivo al almacenamiento.");

                parameters.UrlStorage = resultado.Url;
                parameters.Nombre = resultado.Name;
            }
            var result = await _repository.AddAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
