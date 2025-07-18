﻿/***********
 * Nombre del archivo:  EmpresaResponse.cs
 * Descripción:         Clase DTO que representa la respuesta del módulo Empresa.
 *                      Contiene propiedades que describen la información de una empresa,
 *                      incluyendo identificadores, datos fiscales, ubicación, indicadores financieros,
 *                      estado, fechas de registro y modificación, usuarios responsables,
 *                      descripciones relacionadas y un índice auxiliar.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Definición inicial del DTO EmpresaResponse.
 ***********/

namespace Empresa.Presentation.Empresa.Responses
{
    public class EmpresaResponse
    {
        public int nIdEmpresa { get; set; }
        public string sRuc { get; set; } = string.Empty;
        public string sRazonSocial { get; set; } = string.Empty;
        public int nIdSector { get; set; }
        public int nIdRubroNegocio { get; set; }
        public string sIdDepartamento { get; set; } = string.Empty;
        public string sIdProvincia { get; set; } = string.Empty;
        public string sIdDistrito { get; set; } = string.Empty;
        public string sDireccion { get; set; } = string.Empty;
        public string sComentario { get; set; } = string.Empty;
        public decimal mIngresosUltimoAnio { get; set; }
        public decimal mUtilidadUltimoAnio { get; set; }
        public decimal mConformacionCapitalSocial { get; set; }
        public int nNumeroMiembros { get; set; }
        public bool bRegistradoMercadoValores { get; set; }
        public bool bActivo { get; set; }
        public DateTime dtFechaRegistro { get; set; }
        public int nUsuarioRegistro { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? nUsuarioModificacion { get; set; }
        public string? sDescripcionRubro { get; set; }
        public string? sNombreMinisterio { get; set; }
        public string? sProvinciaDescripcion { get; set; }
        public int indice { get; set; }
    }
}
