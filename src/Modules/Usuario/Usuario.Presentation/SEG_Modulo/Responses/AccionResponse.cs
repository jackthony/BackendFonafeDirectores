/***********
 * Nombre del archivo:  AccionResponse.cs
 * Descripción:         Clase de respuesta que representa una acción del sistema, incluyendo su identificador,
 *                      nombre y si está permitida para el usuario actual.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la estructura de respuesta para acciones dentro de un módulo.
 ***********/

namespace Usuario.Presentation.Modulo.Responses
{
    public class AccionResponse
    {
        public int nAccionId { get; set; }
        public string sNombre { get; set; } = string.Empty;
        public bool permitido { get; set; }
    }
}
