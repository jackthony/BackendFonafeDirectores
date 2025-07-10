/*****
 * Nombre del archivo:  ArchivoResult.cs
 * Descripción:         Clases que representan los resultados de archivos y elementos en el sistema. 
 *                      La clase `ArchivoResult` contiene las propiedades principales de un archivo, como `ElementoId`, `Nombre`, `FechaRegistro`, entre otras.
 *                      Se definen clases base y derivadas como `ElementoBase`, `Carpeta` y `Documento` para modelar distintos tipos de elementos en el sistema.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de las clases.
 *****/
namespace Archivo.Domain.Archivo.Results
{
    public class ArchivoResult
    {
        public int ElementoId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public bool EsDocumento { get; set; }
        public int? CarpetaPadreId { get; set; }
        public int EmpresaId { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public long? Peso { get; set; }
        public string? TipoMime { get; set; }
        public string? UrlStorage { get; set; }
    }
    public abstract class ElementoBase
    {
        public int ElementoId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public bool EsDocumento => this is Documento;
    }

    public class Carpeta : ElementoBase
    {
        public List<ElementoBase> Hijos { get; set; } = [];
    }

    public class Documento : ElementoBase
    {
        public long? Peso { get; set; }
        public string? TipoMime { get; set; }
        public string UrlStorage { get; set; } = string.Empty;
    }

}
