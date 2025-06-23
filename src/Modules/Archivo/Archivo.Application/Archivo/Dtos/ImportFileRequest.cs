using Microsoft.AspNetCore.Http;

namespace Archivo.Application.Archivo.Dtos
{
    public class ImportFileRequest
    {
        public IFormFile Archivo { get; set; } = default!;
        public int nUsuarioId { get; set; }
    }
}
