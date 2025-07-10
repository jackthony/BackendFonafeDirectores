/***********
 * Nombre del archivo:  ModuloConAccionesResult.cs
 * Descripción:         Clase que representa un módulo con sus propiedades y las acciones asociadas
 *                      en formato JSON. Utilizada para devolver resultados combinados de módulos y acciones.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial de la clase de resultado con acciones en JSON.
 ***********/

namespace Usuario.Domain.Modulo.Results
{
    public class ModuloConAccionesResult
    {
        public int ModuloId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Ruta { get; set; }
        public string? Icono { get; set; }
        public bool ModuloPermitido { get; set; }
        public string AccionesJson { get; set; } = string.Empty;
    }
}
