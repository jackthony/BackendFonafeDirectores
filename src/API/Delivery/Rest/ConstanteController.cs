using Empresa.Domain.EMP_Dieta.Models;
using Microsoft.AspNetCore.Mvc;
using Shared.ClientV1;
using Shared.Kernel.Responses;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConstanteController : ControllerBase
    {
        [HttpGet("getDieta")]
        public IActionResult Listar(string sRuc, int nTipoCargo )
        {
            var datos = new List<DietaModel>
            {
                new("12345859845", 1, 2000),
                new("12345859845", 2, 4000),
            };

            var resultado = datos.ToList();

            var response = new LstItemResponse<DietaModel>
            {
                LstItem = resultado,
                IsSuccess = true
            };
            return Ok(response);
        }

        [HttpGet("listar")]
        public IActionResult Listar(int nConCodigo)
        {
            var datos = new List<ConstanteItemResponse>
        {
            new() { nConCodigo = 1, nConValor = 0, sConDescripcion = "Géneros" },
            new() { nConCodigo = 1, nConValor = 1, sConDescripcion = "Masculino" },
            new() { nConCodigo = 1, nConValor = 2, sConDescripcion = "Femenino" },

            new() { nConCodigo = 2, nConValor = 0, sConDescripcion = "Tipo de documento" },
            new() { nConCodigo = 2, nConValor = 1, sConDescripcion = "DNI" },
            new() { nConCodigo = 2, nConValor = 2, sConDescripcion = "Carnet de extranjería" },

            new() { nConCodigo = 10, nConValor = 0, sConDescripcion = "Estado Usuario" },
            new() { nConCodigo = 10, nConValor = 1, sConDescripcion = "Activo" },
            new() { nConCodigo = 10, nConValor = 2, sConDescripcion = "Inactivo" },
            new() { nConCodigo = 10, nConValor = 3, sConDescripcion = "Deshabilitado" },

            new() { nConCodigo = 11, nConValor = 0, sConDescripcion = "Cargo usuario" },
            new() { nConCodigo = 11, nConValor = 1, sConDescripcion = "Analista" },
            new() { nConCodigo = 11, nConValor = 2, sConDescripcion = "Gerente" },
            new() { nConCodigo = 11, nConValor = 3, sConDescripcion = "Especialista" },
        };

            var resultado = datos
                .Where(x => x.nConCodigo == nConCodigo
                         && x.nConValor != 0)
                .ToList();

            var response = new LstItemResponse<ConstanteItemResponse>
            {
                LstItem = resultado,
                IsSuccess = true
            };
            return Ok(response);
        }
    }

}
