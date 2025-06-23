using Microsoft.AspNetCore.Http;

namespace Archivo.Application.Archivo.Dtos
{
    public class CrearArchivoRequest
    {
        public bool IsDocumento { get; set; }
        public IFormFile? Archivo { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int? CarpetaPadreId { get; set; }
        public int UsuarioRegistroId { get; set; }
    }
}
