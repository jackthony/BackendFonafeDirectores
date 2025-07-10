/***********
 * Nombre del archivo:  ServiceSettings.cs
 * Descripción:         Clase de configuración que contiene parámetros de conexión del servicio,
 *                      como la cadena de conexión a la base de datos.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

namespace Api.Settings
{
    public class ServiceSettings
    {
        public string ConnectionString { get; set; } = string.Empty;
    }
}
