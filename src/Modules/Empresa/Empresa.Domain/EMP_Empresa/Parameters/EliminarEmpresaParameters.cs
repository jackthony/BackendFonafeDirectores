namespace Empresa.Domain.Empresa.Parameters
{
    public class EliminarEmpresaParameters
    {
        public int nEmpresaId { get; set; }
        public DateTime? dtFechaModificacion { get; set; } = null;
        public int? nUsuarioModificacionId { get; set; } = null;
    }
}
