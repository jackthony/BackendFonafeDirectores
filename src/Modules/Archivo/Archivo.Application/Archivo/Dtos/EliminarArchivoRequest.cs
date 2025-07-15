/*****
 * Nombre del archivo:  EliminarArchivoRequest.cs
 * Descripción:         Clase de transferencia de datos (DTO) utilizada para la solicitud de eliminación de un archivo. 
 *                      Implementa la interfaz ITrackableRequest, permitiendo registrar el movimiento de eliminación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 15/07/25 por Daniel Alva
 * Cambios recientes:   Agregado soporte para trazabilidad y campo ID del archivo a eliminar.
 *****/
using Shared.Kernel.Interfaces;

namespace Archivo.Application.Archivo.Dtos
{
    public class EliminarArchivoRequest : ITrackableRequest
    {
        public required int ElementoId { get; set; }
        public required int UsuarioEliminacionId { get; set; }

        public int UsuarioId => UsuarioEliminacionId;
        public string Modulo => "ARCHIVO";
        public string Tabla => "Elemento";
        public string CampoId => "nElementoId";
        public int? ValorId => ElementoId;
        public string Movimiento => "Delete";
    }
}
