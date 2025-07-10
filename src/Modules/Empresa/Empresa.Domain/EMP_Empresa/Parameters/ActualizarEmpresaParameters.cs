/***********
 * Nombre del archivo:  ActualizarEmpresaParameters.cs
 * Descripción:         Clase que define los parámetros necesarios para actualizar la información de una empresa existente.
 *                      Contiene información de ubicación, datos económicos y trazabilidad.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para soportar la operación de actualización de empresas.
 ***********/

namespace Empresa.Domain.Empresa.Parameters
{
    public class ActualizarEmpresaParameters
    {
        public int IdEmpresa { get; set; }
        public int IdRubroNegocio { get; set; }
        public int IdSector { get; set; }
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
        public int UsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
