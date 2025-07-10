/*****
 * Nombre del archivo:  ListarArchivoUseCase.cs
 * Descripción:         Caso de uso encargado de gestionar el listado de archivos. 
 *                      Implementa la interfaz `IUseCase`, mapeando la solicitud de listado (`ListarArchivoRequest`) a los parámetros correspondientes (`ListarArchivoParameters`),
 *                      y utilizando el repositorio para obtener los resultados desde la base de datos.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Archivo.Application.Archivo.Dtos;
using Archivo.Domain.Archivo.Parameters;
using Archivo.Domain.Archivo.Repositories;
using Archivo.Domain.Archivo.Results;

namespace Archivo.Application.Archivo.UseCases
{
    public class ListarArchivoUseCase : IUseCase<ListarArchivoRequest, List<ArchivoResult>>
    {
        private readonly IArchivoRepository _repository;
        private readonly IMapper<ListarArchivoRequest, ListarArchivoParameters> _mapper;

        public ListarArchivoUseCase(
            IArchivoRepository repository,
            IMapper<ListarArchivoRequest, ListarArchivoParameters> mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, List<ArchivoResult>>> ExecuteAsync(ListarArchivoRequest request)
        {
            var parameters = _mapper.Map(request);
            var result = await _repository.ListAsync(parameters);
            return result;
        }
    }
}
