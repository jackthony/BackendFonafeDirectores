/*****
 * Nombre del archivo:  IStorageService.cs
 * Descripción:         Interfaz que define los métodos para gestionar el almacenamiento de archivos. 
 *                      Incluye métodos para subir archivos, descargar archivos y subir archivos de prueba.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la interfaz.
 *****/
using Archivo.Application.Archivo.Dtos;
using Microsoft.AspNetCore.Http;

namespace Archivo.Application.Archivo.Services
{
    public interface IStorageService
    {
        public Task<string> SubirArchivoAsync(Stream stream, string rutaArchivo, string contentType);
        public Task<DataArchivoDto?> SubirPrueba(IFormFile file, string remotePath = "");
        public Task<Stream> DescargarArchivoAsync(string rutaCompleta);
    }
}
