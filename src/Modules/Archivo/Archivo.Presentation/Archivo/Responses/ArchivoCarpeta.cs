namespace Archivo.Presentation.Archivo.Responses
{
    public class ArchivoCarpeta : ArchivoNode
    {
        public List<ArchivoNode> ltHijos { get; set; } = [];
        public override bool bEsDocumento => false;
        public override int tipo => 0;
    }
}
