/*****
 * Nombre del archivo:  BunnyStorageOptions.cs
 * Descripción:         Clase que contiene las opciones de configuración para el servicio de almacenamiento de Bunny CDN. 
 *                      Incluye propiedades como `StorageZone`, `ApiKey` y `BaseUrl` para definir el acceso y configuración del servicio de almacenamiento.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
namespace Api.Settings
{
    public class BunnyStorageOptions
    {
        public string StorageZone { get; set; } = string.Empty;
        public string ApiKey { get; set; } = string.Empty;
        public string BaseUrl { get; set; } = "https://storage.bunnycdn.com";
    }
}
