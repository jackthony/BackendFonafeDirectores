/***********
 * Nombre del archivo:  ArchivoController.cs
 * Descripción:         Controlador REST para la gestión completa de archivos.
 *                      Implementa endpoints para crear, actualizar, eliminar, listar (con y sin paginación),
 *                      importar y exportar archivos, así como descargar archivos desde una URL.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial de funcionalidades CRUD y gestión avanzada de archivos.
 ***********/

using Api.Helpers;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Archivo.Application.Archivo.Dtos;
using Archivo.Domain.Archivo.Results;
using Shared.ClientV1;
using Microsoft.AspNetCore.StaticFiles;
using Archivo.Presentation.Archivo.Responses;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class ArchivoController : ControllerBase
    {
        private readonly IUseCase<CrearArchivoRequest, SpResultBase> _crearArchivoUseCase;
        private readonly IUseCase<ActualizarArchivoRequest, SpResultBase> _actualizarArchivoUseCase;
        private readonly IUseCase<EliminarArchivoRequest, SpResultBase> _eliminarArchivoUseCase;
        private readonly IUseCase<ListarArchivoPaginadoRequest, PagedResult<ArchivoResult>> _listarArchivoPaginadaUseCase;
        private readonly IUseCase<ListarArchivoRequest, List<ArchivoResult>> _listarArchivoUseCase;
        private readonly IUseCase<int, ArchivoResult?> _obtenerArchivoPorIdUseCase;
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<bool>> _presenterBool;
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<int>> _presenterInt;
        private readonly IUseCase<ExportFileRequest, Stream> _exportarFileUseCase;
        private readonly IUseCase<ImportFileRequest, ImportFileResult> _importarFileUseCase;
        private readonly IUseCase<string, Stream> _descargarArchivoUseCase;
        private readonly IPresenterDelivery<List<ArchivoResult>, TreeResponse<ArchivoNode>> _presenterList;
        private readonly IPresenterDelivery<List<ArchivoResult>, ListResponse<ElementoNodoResponse<ElementoDetalleResponse>>> _presenterListElement;

        public ArchivoController(IUseCase<CrearArchivoRequest, SpResultBase> crearArchivoUseCase, IUseCase<ActualizarArchivoRequest, SpResultBase> actualizarArchivoUseCase, IUseCase<EliminarArchivoRequest, SpResultBase> eliminarArchivoUseCase, IUseCase<ListarArchivoPaginadoRequest, PagedResult<ArchivoResult>> listarArchivoPaginadaUseCase, IUseCase<ListarArchivoRequest, List<ArchivoResult>> listarArchivoUseCase, IUseCase<int, ArchivoResult?> obtenerArchivoPorIdUseCase, IPresenterDelivery<SpResultBase, ItemResponse<bool>> presenterBool, IPresenterDelivery<SpResultBase, ItemResponse<int>> presenterInt, IUseCase<ExportFileRequest, Stream> exportarFileUseCase, IUseCase<ImportFileRequest, ImportFileResult> importarFileUseCase, IUseCase<string, Stream> descargarArchivoUseCase, IPresenterDelivery<List<ArchivoResult>, TreeResponse<ArchivoNode>> presenterList, IPresenterDelivery<List<ArchivoResult>, ListResponse<ElementoNodoResponse<ElementoDetalleResponse>>> presenterListElement)
        {
            _crearArchivoUseCase = crearArchivoUseCase;
            _actualizarArchivoUseCase = actualizarArchivoUseCase;
            _eliminarArchivoUseCase = eliminarArchivoUseCase;
            _listarArchivoPaginadaUseCase = listarArchivoPaginadaUseCase;
            _listarArchivoUseCase = listarArchivoUseCase;
            _obtenerArchivoPorIdUseCase = obtenerArchivoPorIdUseCase;
            _presenterBool = presenterBool;
            _presenterInt = presenterInt;
            _exportarFileUseCase = exportarFileUseCase;
            _importarFileUseCase = importarFileUseCase;
            _descargarArchivoUseCase = descargarArchivoUseCase;
            _presenterList = presenterList;
            _presenterListElement = presenterListElement;
        }

        [HttpPost("importar")]
        public async Task<IActionResult> Importar([FromForm] ImportFileRequest request)
        {
            var result = await _importarFileUseCase.ExecuteAsync(request);

            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterInt.Present(new SpResultBase { Success = true, Message = "Importación exitosa", Data =  1});
            return Ok(response);
        }

        [HttpPost("exportar")]
        public async Task<IActionResult> Exportar([FromBody] ExportFileRequest request)
        {
            var result = await _exportarFileUseCase.ExecuteAsync(request);

            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);

            var stream = result.AsT1;
            string extension = request.nTipoArchivo == 1 ? ".xlsx" : ".pdf";
            return File(
                stream,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                $"reporte{extension}"
            );
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearArchivo([FromForm] CrearArchivoRequest request)
        {
            var result = await _crearArchivoUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterInt.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("descargar")]
        public async Task<IActionResult> DescargarArchivo([FromQuery] string url)
        {
            var result = await _descargarArchivoUseCase.ExecuteAsync(url);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var stream = result.AsT1;

            var provider = new FileExtensionContentTypeProvider();
            if (!provider.TryGetContentType(url, out var contentType))
            {
                contentType = "application/octet-stream";
            }

            var nombreArchivo = Path.GetFileName(url);

            return File(stream, contentType, nombreArchivo);
        }

        [HttpPost("actualizar")]
        public async Task<IActionResult> ActualizarArchivo([FromBody] ActualizarArchivoRequest request)
        {
            var result = await _actualizarArchivoUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
        }

        [HttpPost("eliminar")]
        public async Task<IActionResult> EliminarArchivo([FromBody] EliminarArchivoRequest request)
        {
            var result = await _eliminarArchivoUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listar-paginado")]
        public async Task<IActionResult> ListarArchivoPaginado([FromQuery] ListarArchivoPaginadoRequest request)
        {
            var result = await _listarArchivoPaginadaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarArchivo([FromQuery] ListarArchivoRequest request)
        {
            var result = await _listarArchivoUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterListElement.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerArchivoPorId(int id)
        {
            var result = await _obtenerArchivoPorIdUseCase.ExecuteAsync(id);
            if (result.IsT0)
                return NotFound();
            return Ok(result.AsT1);
        }
    }
}
