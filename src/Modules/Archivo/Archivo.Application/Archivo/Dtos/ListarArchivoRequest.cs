namespace Archivo.Application.Archivo.Dtos
{
    public class ListarArchivoRequest
    {
        public int? nCarpetaPadreId { get; set; } = null;
        public int? nDirectorId { get; set; } = null;
        public int? nIdEmpresa { get; set; } = null;
    }
}
