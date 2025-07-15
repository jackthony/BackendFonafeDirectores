using Archivo.Domain.Archivo.Results;

namespace Archivo.Presentation.Archivo.Requests
{
    public class PresentarArbolRequest
    {
        public List<ArchivoResult> Archivos { get; set; } = [];
        public int? IdRaiz { get; set; }
    }
}
