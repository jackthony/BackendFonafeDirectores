using Api.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Archivo.Application.Archivo.Dtos;
using Archivo.Domain.Archivo.Results;
using Shared.ClientV1;
using Archivo.Application.Archivo.UseCases;

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

        public ArchivoController(IUseCase<CrearArchivoRequest, SpResultBase> crearArchivoUseCase, IUseCase<ActualizarArchivoRequest, SpResultBase> actualizarArchivoUseCase, IUseCase<EliminarArchivoRequest, SpResultBase> eliminarArchivoUseCase, IUseCase<ListarArchivoPaginadoRequest, PagedResult<ArchivoResult>> listarArchivoPaginadaUseCase, IUseCase<ListarArchivoRequest, List<ArchivoResult>> listarArchivoUseCase, IUseCase<int, ArchivoResult?> obtenerArchivoPorIdUseCase, IPresenterDelivery<SpResultBase, ItemResponse<bool>> presenterBool, IPresenterDelivery<SpResultBase, ItemResponse<int>> presenterInt, IUseCase<ExportFileRequest, Stream> exportarFileUseCase)
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
        }

        [HttpPost("exportar")]
        public async Task<IActionResult> Exportar([FromBody] ExportFileRequest request)
        {
            var result = await _exportarFileUseCase.ExecuteAsync(request);

            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);

            var stream = result.AsT1;
            return File(
                stream,
                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                "reporte.xlsx"
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
        public IActionResult ListarArchivo([FromQuery] ListarArchivoRequest request)
        {
            /*var result = await _listarArchivoUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);*/
            var raiz = new Carpeta
            {
                ElementoId = 1,
                Nombre = "Raíz",
                Hijos = new List<ElementoBase>
        {
            new Carpeta
            {
                ElementoId = 2,
                Nombre = "Carpeta 1",
                Hijos = new List<ElementoBase>
                {
                    new Documento
                    {
                        ElementoId = 3,
                        Nombre = "archivo1.pdf",
                        Peso = 123456,
                        TipoMime = "application/pdf",
                        UrlStorage = "https://fake-url.com/archivo1.pdf"
                    }
                }
            },
            new Documento
            {
                ElementoId = 4,
                Nombre = "archivo2.docx",
                Peso = 98765,
                TipoMime = "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
                UrlStorage = "https://fake-url.com/archivo2.docx"
            }
        }
            };

            return Ok(raiz);
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
