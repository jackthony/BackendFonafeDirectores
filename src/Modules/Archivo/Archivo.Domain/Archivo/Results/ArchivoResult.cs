namespace Archivo.Domain.Archivo.Results
{
    public class ArchivoResult
    {
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
