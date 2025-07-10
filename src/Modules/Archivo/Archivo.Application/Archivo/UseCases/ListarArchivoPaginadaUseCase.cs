/*****
 * Nombre del archivo:  ListarArchivoPaginadaUseCase.cs
 * Descripción:         Caso de uso encargado de gestionar el listado paginado de archivos. 
 *                      Implementa la interfaz `IUseCase`, mapeando la solicitud de listado paginado (`ListarArchivoPaginadoRequest`) a los parámetros correspondientes (`ListarArchivoPaginadoParameters`),
 *                      y utilizando el repositorio para obtener los resultados de la base de datos con paginación.
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
using Archivo.Domain.Archivo.Results;

namespace Archivo.Application.Archivo.UseCases
{
    public class ListarArchivoPaginadaUseCase : IUseCase<ListarArchivoPaginadoRequest, PagedResult<ArchivoResult>>
    {
        private readonly IArchivoRepository _repository;
        private readonly IMapper<ListarArchivoPaginadoRequest, ListarArchivoPaginadoParameters> _mapper;

        public ListarArchivoPaginadaUseCase(
            IArchivoRepository repository,
            IMapper<ListarArchivoPaginadoRequest, ListarArchivoPaginadoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, PagedResult<ArchivoResult>>> ExecuteAsync(ListarArchivoPaginadoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListByPaginationAsync(parameters);
            return result;
        }
    }
}
