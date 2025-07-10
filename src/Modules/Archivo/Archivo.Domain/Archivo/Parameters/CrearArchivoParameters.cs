/***
 * Nombre del archivo:  CrearArchivoParameters.cs
 * Descripción:         Clase que contiene los parámetros necesarios para realizar la creación de un archivo. 
 *                      Incluye propiedades como IsDocumento, Nombre, FechaRegistro, entre otras, 
 *                      que definen los detalles del archivo a ser creado en la base de datos.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 ***/
namespace Archivo.Domain.Archivo.Parameters
{
    public class CrearArchivoParameters
    {
        public bool IsDocumento { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int? CarpetaPadreId { get; set; }
        public int UsuarioRegistroId { get; set; }
        public required string EmpresaId { get; set; }
        public int? DirectorId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public long? Peso { get; set; }
        public string? TipoMime { get; set; }
        public string? UrlStorage { get; set; }
    }
}
