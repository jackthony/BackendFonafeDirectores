/***********
 * Nombre del archivo:  ModuloPermiso.cs
 * Descripción:         Modelo que representa un módulo con su nombre y una lista de permisos asociados.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase para gestionar permisos agrupados por módulo.
 ***********/

namespace Usuario.Domain.SEG_Modulo.Models
{
    public class ModuloPermiso
    {
        public string NombreModulo { get; set; } = string.Empty;
        public List<Permiso> Permisos { get; set; } = [];
    }
}
