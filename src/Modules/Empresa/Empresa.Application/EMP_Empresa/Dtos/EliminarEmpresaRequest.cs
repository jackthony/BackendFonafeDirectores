namespace Empresa.Application.Empresa.Dtos
{
    public class EliminarEmpresaRequest
    {
        public int nEmpresaId { get; set; }
        public DateTime? dtFechaModificacion { get; set; } = null;
        public int? nUsuarioModificacionId { get; set; } = null;
    }
}
