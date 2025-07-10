/*****
 * Nombre del archivo:  ObtenerArchivoPorIdUseCase.cs
 * Descripción:         Caso de uso encargado de obtener un archivo por su ID. 
 *                      Implementa la interfaz `IUseCase`, utilizando el repositorio para recuperar los detalles del archivo desde la base de datos.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Archivo.Domain.Archivo.Repositories;
using Archivo.Domain.Archivo.Results;

namespace Archivo.Application.Archivo.UseCases
{
    public class ObtenerArchivoPorIdUseCase : IUseCase<int, ArchivoResult?>
    {
        private readonly IArchivoRepository _repository;

        public ObtenerArchivoPorIdUseCase(IArchivoRepository repository)
        {
            _repository = repository;
        }

        public async Task<OneOf<ErrorBase, ArchivoResult?>> ExecuteAsync(int request)
        {
            var result = await _repository.GetByIdAsync(request);
            if (result == null) return ErrorBase.NotFound();
            return result;
        }
    }
}
