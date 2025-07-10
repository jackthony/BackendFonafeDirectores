/***********
 * Nombre del archivo:  CrearEmpresaParameters.cs
 * Descripción:         Clase que encapsula los parámetros requeridos para registrar una nueva empresa.
 *                      Incluye datos generales, ubicación, indicadores económicos y trazabilidad.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para soportar la operación de registro de empresas.
 ***********/

namespace Empresa.Domain.Empresa.Parameters
{
    public class CrearEmpresaParameters
    {
        public string Ruc { get; set; } = string.Empty;
        public string RazonSocial { get; set; } = string.Empty;
        public int IdSector { get; set; }
        public int IdRubroNegocio { get; set; }
        public int IdDepartamento { get; set; }
        public int IdProvincia { get; set; }
        public int IdDistrito { get; set; }
        public string Direccion { get; set; } = string.Empty;
        public string Comentario { get; set; } = string.Empty;
        public int NumeroMiembros { get; set; }
        public decimal IngresosUltimoAnio { get; set; }
        public decimal UtilidadUltimoAnio { get; set; }
        public decimal ConformacionCapitalSocial { get; set; }
        public bool RegistradoMercadoValores { get; set; }
        public bool Activo { get; set; }
        public int UsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
