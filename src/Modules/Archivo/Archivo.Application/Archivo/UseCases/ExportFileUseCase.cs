/*****
 * Nombre del archivo:  ExportFileUseCase.cs
 * Descripción:         Caso de uso encargado de gestionar la exportación de archivos. 
 *                      Implementa la interfaz `IUseCase`, mapeando la solicitud de exportación (`ExportFileRequest`) a los parámetros correspondientes (`ExportParameters`),
 *                      y utilizando el servicio y repositorio para obtener los datos necesarios y generar el archivo de exportación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Archivo.Application.Archivo.Dtos;
using Archivo.Application.Archivo.Services;
using Archivo.Domain.Archivo.Parameters;
using Archivo.Domain.Archivo.Repositories;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Archivo.Application.Archivo.UseCases
{
    public class ExportFileUseCase : IUseCase<ExportFileRequest, Stream>
    {
        private readonly IExportImportService _service;
        private readonly IExportImportRepository _repository;
        private readonly IMapper<ExportFileRequest, ExportParameters> _mapper;

        public ExportFileUseCase(IExportImportService service, IExportImportRepository repository, IMapper<ExportFileRequest, ExportParameters> mapper)
        {
            _service = service;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OneOf<ErrorBase, Stream>> ExecuteAsync(ExportFileRequest request)
        {
            var parameters = _mapper.Map(request);

            var empresas = await _repository.GetEmpresas(parameters);
            if (empresas == null || empresas.Count == 0)
                return ErrorBase.NotFound();

            var directores = await _repository.GetDirectores(parameters);
            if (directores == null || directores.Count == 0)
                return ErrorBase.NotFound();

            var stream = _service.ObtenerDatosExportAsync(empresas, directores, request.nTipoArchivo);

            return stream;
        }
    }
}
