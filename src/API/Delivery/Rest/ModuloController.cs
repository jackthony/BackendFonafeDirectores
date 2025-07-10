/***********
 * Nombre del archivo:  ModuloController.cs
 * Descripción:         Controlador REST para la obtención de módulos con sus respectivas acciones asociadas a un rol.
 *                      Expone el endpoint para listar los módulos disponibles con sus permisos asignables.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación del endpoint para listar módulos con acciones por rol.
 ***********/

using Api.Helpers;
using Microsoft.AspNetCore.Mvc;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Usuario.Domain.Modulo.Results;
using Usuario.Presentation.Modulo.Responses;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModuloController : ControllerBase
    {
        private readonly IUseCase<int, List<ModuloConAccionesResult>> _listarModulosConAccionesUseCase;
        private readonly IPresenterDelivery<List<ModuloConAccionesResult>, LstItemResponse<ModuloConAccionesResponse>> _presenterModulosConAcciones;

        public ModuloController(IUseCase<int, List<ModuloConAccionesResult>> listarModulosConAccionesUseCase, IPresenterDelivery<List<ModuloConAccionesResult>, LstItemResponse<ModuloConAccionesResponse>> presenterModulosConAcciones)
        {
            _listarModulosConAccionesUseCase = listarModulosConAccionesUseCase;
            _presenterModulosConAcciones = presenterModulosConAcciones;
        }

        [HttpGet("listarModulosAcciones")]
        public async Task<IActionResult> ListarCargo([FromQuery] int rolId)
        {
            var result = await _listarModulosConAccionesUseCase.ExecuteAsync(rolId);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterModulosConAcciones.Present(result.AsT1);
            return Ok(response);
        }
    }
}
