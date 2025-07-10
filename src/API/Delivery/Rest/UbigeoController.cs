/***********
 * Nombre del archivo:  UbigeoController.cs
 * Descripción:         Controlador REST encargado de exponer endpoints relacionados con la estructura 
 *                      geográfica del Perú (departamentos, provincias y distritos). Utiliza casos de uso
 *                      específicos y presentadores para mapear la lógica de negocio a respuestas estándar.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial del controlador con endpoints de listado por nivel geográfico.
 ***********/

using Api.Helpers;
using Empresa.Application.Ubigeo.Dtos;
using Empresa.Domain.Ubigeo.Results;
using Empresa.Presentation.Ubigeo.Responses;
using Microsoft.AspNetCore.Mvc;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class UbigeoController : ControllerBase
    {
        private readonly IUseCase<ListarDepartamentoRequest, List<DepartamentoResult>> _departamentoUseCase;
        private readonly IUseCase<ListarProvinciaRequest, List<ProvinciaResult>> _provinciaUseCase;
        private readonly IUseCase<ListarDistritoRequest, List<DistritoResult>> _distritoUseCase;
        private readonly IPresenterDelivery<List<DepartamentoResult>, LstItemResponse<DepartamentoResponse>> _presenterDepartmaneto;
        private readonly IPresenterDelivery<List<ProvinciaResult>, LstItemResponse<ProvinciaResponse>> _presenterProvincia;
        private readonly IPresenterDelivery<List<DistritoResult>, LstItemResponse<DistritoResponse>> _presenterDistrito;

        public UbigeoController(IUseCase<ListarDepartamentoRequest, List<DepartamentoResult>> departamentoUseCase, IUseCase<ListarProvinciaRequest, List<ProvinciaResult>> provinciaUseCase, IUseCase<ListarDistritoRequest, List<DistritoResult>> distritoUseCase, IPresenterDelivery<List<DepartamentoResult>, LstItemResponse<DepartamentoResponse>> presenterDepartmaneto, IPresenterDelivery<List<ProvinciaResult>, LstItemResponse<ProvinciaResponse>> presenterProvincia, IPresenterDelivery<List<DistritoResult>, LstItemResponse<DistritoResponse>> presenterDistrito)
        {
            _departamentoUseCase = departamentoUseCase;
            _provinciaUseCase = provinciaUseCase;
            _distritoUseCase = distritoUseCase;
            _presenterDepartmaneto = presenterDepartmaneto;
            _presenterProvincia = presenterProvincia;
            _presenterDistrito = presenterDistrito;
        }

        [HttpGet("listarDepartamentos")]
        public async Task<IActionResult> ListarDepartamentos([FromQuery] ListarDepartamentoRequest request)
        {
            var result = await _departamentoUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterDepartmaneto.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listarProvincias")]
        public async Task<IActionResult> ListarProvincias([FromQuery] ListarProvinciaRequest request)
        {
            var result = await _provinciaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterProvincia.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listarDistritos")]
        public async Task<IActionResult> ListarDistritos([FromQuery] ListarDistritoRequest request)
        {
            var result = await _distritoUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterDistrito.Present(result.AsT1);
            return Ok(response);
        }
    }
}
