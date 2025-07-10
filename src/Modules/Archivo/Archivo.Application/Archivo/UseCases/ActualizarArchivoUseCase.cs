/*****
 * Nombre del archivo:  ActualizarArchivoUseCase.cs
 * Descripción:         Caso de uso encargado de gestionar la actualización de archivos. 
 *                      Implementa la interfaz `IUseCase`, mapeando la solicitud de actualización (`ActualizarArchivoRequest`) a los parámetros correspondientes (`ActualizarArchivoParameters`), 
 *                      y utilizando el repositorio para realizar la actualización en la base de datos.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Archivo.Application.Archivo.Dtos;
using Archivo.Domain.Archivo.Parameters;
using Archivo.Domain.Archivo.Repositories;

namespace Archivo.Application.Archivo.UseCases
{
    public class ActualizarArchivoUseCase : IUseCase<ActualizarArchivoRequest, SpResultBase>
    {
        private readonly IArchivoRepository _repository;
        private readonly IMapper<ActualizarArchivoRequest, ActualizarArchivoParameters> _mapper;

        public ActualizarArchivoUseCase(IArchivoRepository repository, IMapper<ActualizarArchivoRequest, ActualizarArchivoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ActualizarArchivoRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.UpdateAsync(parameters);
            if (!result.Success) return ErrorBase.Database(result.Message);
            return result;
        }
    }
}
