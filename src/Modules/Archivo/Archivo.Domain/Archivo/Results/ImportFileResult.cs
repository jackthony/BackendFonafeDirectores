namespace Archivo.Domain.Archivo.Results
{
    public class ImportFileResult
    {
        public List<EmpresaDocResult> Empresas { get; set; } = new();
        public List<DirectorDocResult> Directores { get; set; } = new();
    }
}
