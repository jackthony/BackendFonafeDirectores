using Api.Helpers;
using Empresa.Application.Cargo.Dtos;
using Empresa.Application.Cargo.UseCases;
using Microsoft.AspNetCore.Mvc;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
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
