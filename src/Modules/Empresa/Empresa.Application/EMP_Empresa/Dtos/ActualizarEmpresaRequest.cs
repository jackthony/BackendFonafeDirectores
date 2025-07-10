/*****
 * Nombre del archivo:  ActualizarEmpresaRequest.cs
 * Descripción:         Define el DTO para actualizar los datos de una empresa.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Se ha configurado el DTO para actualizar la información de una empresa, incluyendo los campos requeridos y los detalles de la solicitud de seguimiento.
 *****/
using Shared.Kernel.Interfaces;

namespace Empresa.Application.Empresa.Dtos
{
    public class ActualizarEmpresaRequest : ITrackableRequest
    {
        public int nIdEmpresa { get; set; }
        public int nIdRubroNegocio { get; set; }
        public int nIdSector { get; set; }
        public string sIdDepartamento { get; set; } = string.Empty;
        public string sIdProvincia { get; set; } = string.Empty;
        public string sIdDistrito { get; set; } = string.Empty;
        public string sDireccion { get; set; } = string.Empty;
        public string sComentario { get; set; } = string.Empty;
        public int nNumeroMiembros { get; set; }
        public decimal mIngresosUltimoAnio { get; set; }
        public decimal mUtilidadUltimoAnio { get; set; }
        public decimal mConformacionCapitalSocial { get; set; }
        public bool bRegistradoMercadoValores { get; set; }
        public bool bActivo { get; set; }
        public int nUsuarioModificacion { get; set; }

        public int UsuarioId => nUsuarioModificacion;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Empresa";
        public string CampoId => "nEmpresaId";
        public int? ValorId => nIdEmpresa;
        public string Movimiento => "Update";
    }
}
