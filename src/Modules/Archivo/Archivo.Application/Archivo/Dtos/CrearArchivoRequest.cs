/*****
 * Nombre del archivo:  CrearArchivoRequest.cs
 * Descripción:         Clase de transferencia de datos (DTO) utilizada para la solicitud de creación de un archivo. 
 *                      Implementa la interfaz ITrackableRequest, permitiendo el seguimiento de la solicitud. 
 *                      Contiene las propiedades necesarias para registrar información sobre el archivo a crear.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Microsoft.AspNetCore.Http;
using Shared.Kernel.Interfaces;

namespace Archivo.Application.Archivo.Dtos
{
    public class CrearArchivoRequest : ITrackableRequest
    {
        public required bool IsDocumento { get; set; }
        public IFormFile? Archivo { get; set; }
        public required string EmpresaId { get; set; }
        public int? DirectorId { get; set; }
        public int? CarpetaPadreId { get; set; }
        public int UsuarioRegistroId { get; set; }

        public int UsuarioId => UsuarioRegistroId;
        public string Modulo => "ARCHIVO";
        public string Tabla => "Elemento";
        public string CampoId => "nElementoId";
        public int? ValorId => null;
        public string Movimiento => "Create";
    }
}
