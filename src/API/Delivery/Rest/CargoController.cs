using Api.Helpers;
using Empresa.Application.EMP_Cargo.Dtos;
using Empresa.Application.EMP_Cargo.Mappers;
using Empresa.Application.EMP_Cargo.UseCases;
using Empresa.Application.EMP_Empresa.Dtos;
using Empresa.Domain.EMP_Cargo.Models;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    public class CargoController : ControllerBase
    {
        private readonly IUseCase<CrearCargoData, SpResultBase> _crearCargoUseCase;
        private readonly IMapper<CrearCargoRequest, CrearCargoData> _crearCargoMapper;

        private readonly IUseCase<ActualizarCargoData, SpResultBase> _actualizarCargoUseCase;
        private readonly IMapper<ActualizarCargoRequest, ActualizarCargoData> _actualizarCargoMapper;

        private readonly IUseCase<EliminarCargoData, SpResultBase> _eliminarCargoUseCase;
        private readonly IMapper<EliminarCargoRequest, EliminarCargoData> _eliminarCargoMapper;

        public CargoController(
            IUseCase<CrearCargoData, SpResultBase> crearCargoUseCase,
            IMapper<CrearCargoRequest, CrearCargoData> crearCargoMapper,
            IUseCase<ActualizarCargoData, SpResultBase> actualizarCargoUseCase,
            IMapper<ActualizarCargoRequest, ActualizarCargoData> actualizarCargoMapper,
            IUseCase<EliminarCargoData, SpResultBase> eliminarCargoUseCase,
            IMapper<EliminarCargoRequest, EliminarCargoData> eliminarCargoMapper)
        {
            _crearCargoUseCase = crearCargoUseCase;
            _crearCargoMapper = crearCargoMapper;

            _actualizarCargoUseCase = actualizarCargoUseCase;
            _actualizarCargoMapper = actualizarCargoMapper;

            _eliminarCargoUseCase = eliminarCargoUseCase;
            _eliminarCargoMapper = eliminarCargoMapper;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> Crear([FromBody] CrearCargoRequest request)
        {
            var data = _crearCargoMapper.Map(request);
            var result = await _crearCargoUseCase.ExecuteAsync(data);

            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);

            return Ok(result.AsT1);
        }

        [HttpPut("actualizar")]
        public async Task<IActionResult> Actualizar([FromBody] ActualizarCargoRequest request)
        {
            var data = _actualizarCargoMapper.Map(request);
            var result = await _actualizarCargoUseCase.ExecuteAsync(data);

            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);

            return Ok(result.AsT1);
        }

        [HttpDelete("eliminar")]
        public async Task<IActionResult> Eliminar([FromBody] EliminarCargoRequest request)
        {
            var data = _eliminarCargoMapper.Map(request);
            var result = await _eliminarCargoUseCase.ExecuteAsync(data);

            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);

            return Ok(result.AsT1);
        }
    }
}
