﻿/***********
 * Nombre del archivo:  CrearTipoDirectorParameters.cs
 * Descripción:         Clase que define los parámetros necesarios para registrar un nuevo tipo de director,
 *                      incluyendo el nombre y los datos de trazabilidad de registro.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de los parámetros para creación de tipo de director.
 ***********/

namespace Empresa.Domain.TipoDirector.Parameters
{
    public class CrearTipoDirectorParameters
    {
        public string NombreTipoDirector { get; set; } = default!;
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
