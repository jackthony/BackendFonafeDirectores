using Api.Helpers;
<<<<<<< HEAD
using Empresa.Application.EMP_Cargo.Dtos;
using Empresa.Application.EMP_Cargo.Mappers;
using Empresa.Application.EMP_Cargo.UseCases;
using Empresa.Application.EMP_Empresa.Dtos;
using Empresa.Domain.EMP_Cargo.Models;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
=======
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Cargo.Dtos;
using Empresa.Domain.Cargo.Results;
using Empresa.Presentation.Cargo.Responses;
using Shared.ClientV1;
>>>>>>> origin/masterboa

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
<<<<<<< HEAD
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
=======
    //[Authorize]
    public class CargoController : ControllerBase
    {
        private readonly IUseCase<CrearCargoRequest, SpResultBase> _crearCargoUseCase;
        private readonly IUseCase<ActualizarCargoRequest, SpResultBase> _actualizarCargoUseCase;
        private readonly IUseCase<EliminarCargoRequest, SpResultBase> _eliminarCargoUseCase;
        private readonly IUseCase<ListarCargoPaginadoRequest, PagedResult<CargoResult>> _listarCargoPaginadaUseCase;
        private readonly IUseCase<ListarCargoRequest, List<CargoResult>> _listarCargoUseCase;
        private readonly IUseCase<int, CargoResult?> _obtenerCargoPorIdUseCase;
        private readonly IPresenterDelivery<PagedResult<CargoResult>, LstItemResponse<CargoResponse>> _presenterListPage;
        private readonly IPresenterDelivery<List<CargoResult>, LstItemResponse<CargoResponse>> _presenterList;
        private readonly IPresenterDelivery<CargoResult, ItemResponse<CargoResponse>> _presenterObtenerId;
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<bool>> _presenterBool;
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<int>> _presenterInt;

        public CargoController(IUseCase<CrearCargoRequest, SpResultBase> crearCargoUseCase, IUseCase<ActualizarCargoRequest, SpResultBase> actualizarCargoUseCase, IUseCase<EliminarCargoRequest, SpResultBase> eliminarCargoUseCase, IUseCase<ListarCargoPaginadoRequest, PagedResult<CargoResult>> listarCargoPaginadaUseCase, IUseCase<ListarCargoRequest, List<CargoResult>> listarCargoUseCase, IUseCase<int, CargoResult?> obtenerCargoPorIdUseCase, IPresenterDelivery<PagedResult<CargoResult>, LstItemResponse<CargoResponse>> presenterListPage, IPresenterDelivery<List<CargoResult>, LstItemResponse<CargoResponse>> presenterList, IPresenterDelivery<CargoResult, ItemResponse<CargoResponse>> presenterObtenerId, IPresenterDelivery<SpResultBase, ItemResponse<bool>> presenterBool, IPresenterDelivery<SpResultBase, ItemResponse<int>> presenterInt)
        {
            _crearCargoUseCase = crearCargoUseCase;
            _actualizarCargoUseCase = actualizarCargoUseCase;
            _eliminarCargoUseCase = eliminarCargoUseCase;
            _listarCargoPaginadaUseCase = listarCargoPaginadaUseCase;
            _listarCargoUseCase = listarCargoUseCase;
            _obtenerCargoPorIdUseCase = obtenerCargoPorIdUseCase;
            _presenterListPage = presenterListPage;
            _presenterList = presenterList;
            _presenterObtenerId = presenterObtenerId;
            _presenterBool = presenterBool;
            _presenterInt = presenterInt;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearCargo([FromBody] CrearCargoRequest request)
        {
            var result = await _crearCargoUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterInt.Present(result.AsT1);
            return Ok(response);
        }

        [HttpPost("actualizar")]
        public async Task<IActionResult> ActualizarCargo([FromBody] ActualizarCargoRequest request)
        {
            var result = await _actualizarCargoUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
        }

        [HttpPost("eliminar")]
        public async Task<IActionResult> EliminarCargo([FromBody] EliminarCargoRequest request)
        {
            var result = await _eliminarCargoUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listar-paginado")]
        public async Task<IActionResult> ListarCargoPaginado([FromQuery] ListarCargoPaginadoRequest request)
        {
            var result = await _listarCargoPaginadaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterListPage.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarCargo([FromQuery] ListarCargoRequest request)
        {
            var result = await _listarCargoUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterList.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerCargoPorId(int id)
        {
            var result = await _obtenerCargoPorIdUseCase.ExecuteAsync(id);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            if (result.AsT1 == null)
                return NotFound();
            var response = _presenterObtenerId.Present(result.AsT1);
            return Ok(response);
>>>>>>> origin/masterboa
        }
    }
}
