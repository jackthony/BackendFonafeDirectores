/***********
 * Nombre del archivo:  SpResultBase.cs
 * Descripción:         Clase base para encapsular resultados de procedimientos almacenados. Implementa
 *                      interfaces de trazabilidad y sistema, incluyendo propiedades como éxito, mensaje,
 *                      y datos asociados.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***********/

using Shared.Kernel.Interfaces;

namespace Shared.Kernel.Responses
{
    public class SpResultBase : ITrackableResponse, ISistemaResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public int Data { get; set; }

        public int ValorId => Data;

        public int? UsuarioId => Data;
        public string? GetSessionId => null;
    }
}
