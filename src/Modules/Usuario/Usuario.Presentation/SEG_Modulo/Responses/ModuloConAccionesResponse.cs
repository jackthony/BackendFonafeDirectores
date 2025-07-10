/***********
 * Nombre del archivo:  ModuloConAccionesResponse.cs
 * Descripción:         Clase de respuesta utilizada para representar un módulo con sus acciones asociadas.
 *                      Incluye información del módulo (nombre, ruta, ícono, permisos) y una lista de acciones.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Definición inicial de la estructura de respuesta del módulo con acciones.
 ***********/

namespace Usuario.Presentation.Modulo.Responses
{
    public class ModuloConAccionesResponse
    {
        public int nModuloId { get; set; }
        public string sNombre { get; set; } = string.Empty;
        public string? sRuta { get; set; }
        public string? sIcono { get; set; }
        public bool bModuloPermitido { get; set; }
        public List<AccionResponse> acciones { get; set; } = [];
    }
}
