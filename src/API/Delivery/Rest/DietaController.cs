/***********
 * Nombre del archivo:  DietaController.cs
 * Descripción:         Controlador REST para obtener información de Dietas mediante consultas.
 *                      Implementa endpoint para obtener una Dieta según criterios de búsqueda.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial del endpoint para obtener Dieta.
 ***********/

using Api.Helpers;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Shared.ClientV1;
using Empresa.Application.Dieta.Dtos;
using Empresa.Domain.Dieta.Results;
using Empresa.Presentation.Dieta.Responses;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    public class DietaController : ControllerBase
    {
        private readonly IUseCase<ObtenerDietaRequest, DietaResult?> _obtenerDietaUseCase;
        private readonly IPresenterDelivery<DietaResult, ItemResponse<DietaResponse>> _presenter;

        public DietaController(
            IUseCase<ObtenerDietaRequest, DietaResult?> obtenerDietaUseCase,
            IPresenterDelivery<DietaResult, ItemResponse<DietaResponse>> presenter)
        {
            _obtenerDietaUseCase = obtenerDietaUseCase;
            _presenter = presenter;
        }

        [HttpGet("obtener")]
        public async Task<IActionResult> ObtenerDieta([FromQuery] ObtenerDietaRequest request)
        {
            var result = await _obtenerDietaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);

            if (result.AsT1 == null)
                return NotFound();

            var response = _presenter.Present(result.AsT1);
            return Ok(response);
        }
    }
}
