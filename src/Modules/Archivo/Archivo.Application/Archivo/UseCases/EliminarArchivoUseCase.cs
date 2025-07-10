/*****
 * Nombre del archivo:  EliminarArchivoUseCase.cs
 * Descripción:         Caso de uso encargado de gestionar la eliminación de archivos. 
 *                      Implementa la interfaz `IUseCase`, mapeando la solicitud de eliminación (`EliminarArchivoRequest`) a los parámetros correspondientes (`EliminarArchivoParameters`),
 *                      y utilizando el repositorio para realizar la eliminación en la base de datos.
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

namespace Archivo.Application.Archivo.UseCases
{
    public class EliminarArchivoUseCase : IUseCase<EliminarArchivoRequest, SpResultBase>
    {
        private readonly IArchivoRepository _repository;
        private readonly IMapper<EliminarArchivoRequest, EliminarArchivoParameters> _mapper;

        public EliminarArchivoUseCase(
            IArchivoRepository repository,
            IMapper<EliminarArchivoRequest, EliminarArchivoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(EliminarArchivoRequest request)
        {
            var parameters = _mapper.Map(request);

            var result = await _repository.DeleteAsync(parameters);

            if (!result.Success) return ErrorBase.Database(result.Message);

            return result;
        }
    }
}
