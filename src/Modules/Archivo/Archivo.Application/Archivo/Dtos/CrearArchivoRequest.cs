using Microsoft.AspNetCore.Http;

namespace Archivo.Application.Archivo.Dtos
{
    public class CrearArchivoRequest
    {
        public required bool IsDocumento { get; set; }
        public IFormFile? Archivo { get; set; }
        public required string EmpresaId {  get; set; }
        public int? DirectorId {  get; set; }
        public int? CarpetaPadreId { get; set; }
        public int UsuarioRegistroId { get; set; }
    }
}
