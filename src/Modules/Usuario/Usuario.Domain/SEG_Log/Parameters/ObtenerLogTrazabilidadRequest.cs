﻿/***********
 * Nombre del archivo:  ObtenerLogTrazabilidadRequest.cs
 * Descripción:         DTO para solicitar logs de trazabilidad en un rango
 *                      de fechas específico.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación del request para consulta de logs de trazabilidad.
 ***********/

namespace Usuario.Domain.SEG_Log.Parameters
{
    public class ObtenerLogTrazabilidadRequest
    {
        public required DateTime FechaInicio { get; set; }
        public required DateTime FechaFin { get; set; }
    }
}
