namespace Archivo.Presentation.Archivo.Responses
{
    public class ArchivoDocumento : ArchivoNode
    {
        public long? nPeso { get; set; }
        public string? sTipoMime { get; set; }
        public string? sUrlStorage { get; set; }

        public override bool bEsDocumento => true;
        public override int tipo => 1;
    }
}
